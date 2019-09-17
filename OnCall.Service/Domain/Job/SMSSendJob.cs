using OnCall.Service.Domain.Entity;
using OnCall.Service.Domain.Enum;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnCall.Service.Domain.Ext;
using System.Threading.Tasks;

namespace OnCall.Service.Domain.Job
{
    /*
      * 该Job职责：从【OnCall->MessageQueue】抓取短信类消息，并进行调用阿里云短信发送
      * 
      * 1、【发送成功】将设置状态为成功，并从MessageQueue 移动到 MessageSuccess
      * 2、【发送失败】将状态设为为失败，并累计FaultCount错误数
      * 
      * 反馈错误码URL
      * https://error-center.aliyun.com/status/product/Dysmsapi?spm=a2c4g.11186623.0.0.184356e0igUB3e
      */
    public class SMSSendJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {

            Task.Factory.StartNew(() =>
            {

                try
                {
                    //获取所有待发送短信报警
                    var listSms = JobDbAssist.Instance.GetWaitSendMessageQueue((int)eMessageType.SMS);

                    if (listSms.Count() == 0)//Job新报警空闲时(暂无新告警)
                    {
                        //重发之前发送异常的数据
                        listSms = JobDbAssist.Instance.GetWaitAgainSendMessageQueue((int)eMessageType.SMS);
                    }

                    if (listSms.Count() > 0)
                    {

                        //更新短信发送数量
                        JobDispatch.UISMSCount?.Invoke(listSms.Count());

                        foreach (VMessageQueye item in listSms)
                        {
                            //设置状态为发送中
                            JobDbAssist.Instance.SetSMSMessageQueueStatus(item.ID, (int)eSendStatus.Sending);

                            //需要短信模板转换-> [发送]
                            string resultMsgJson = new SMSSender().Sender(item.Mobile, item.MessageContent);

                            EResultMessage resultMsg = resultMsgJson.ToObject<EResultMessage>();

                            //反馈码
                            string resultMsgCode = resultMsg.Code.ToLower();

                            //根据反馈消息设置MessageQueye 反馈字段ResultMessage  和 Send 状态
                            JobDbAssist.Instance.SetSMSResultSendMessageQueue(item.ID, resultMsgJson, resultMsgCode == "ok");

                            if (resultMsgCode == "ok")
                            {
                                JobDispatch.UISMSCount?.Invoke(1);
                                JobDispatch.UIDispalyTask("{0} 【短信发送】".Format(context.JobDetail.Key.Name), "发送成功", (int)eJobStatus.OK);
                            }
                            else
                            {
                                JobDispatch.UIDispalyTask("{0} 【短信发送】".Format(context.JobDetail.Key.Name), "发送失败", (int)eJobStatus.Fault);
                            }

                        }

                    }


                }
                catch (Exception ex)
                {
                    Log.WriteFormat("A-【SMSSendJob 短信发送异常】Job异常：{0}", ex.Message);
                    JobDispatch.UIDispalyTask("{0} 【短信发送异常】".Format(context.JobDetail.Key.Name), ex.Message, (int)eJobStatus.Exception);
                }


            });


        }
    }
}
