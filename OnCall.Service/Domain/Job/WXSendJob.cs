using OnCall.Service.Domain.Enum;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnCall.Service.Domain.Ext;

namespace OnCall.Service.Domain.Job
{   
    /*
      * 该Job职责：从【OnCall->MessageQueue】抓取短信类消息，并进行调用微信公众号推送
      * 
      * 1、【发送成功】将设置状态为成功，并从MessageQueue 移动到 MessageSuccess
      * 2、【发送失败】将状态设为为失败，并累计FaultCount错误数
      * 
      */
    public class WXSendJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    //获取所有待推送微信报警
                    var listSms = JobDbAssist.Instance.GetWaitSendMessageQueue((int)eMessageType.WeChat);


                }
                catch (Exception ex)
                {
                    Log.WriteFormat("A-【WXSendJob 企业微信推送异常】Job异常：{0}", ex.Message);
                    JobDispatch.UIDispalyTask("{0} 【微信推送异常】".Format(context.JobDetail.Key.Name), ex.Message, (int)eJobStatus.Exception);
                }

            });
        }
    }
}
