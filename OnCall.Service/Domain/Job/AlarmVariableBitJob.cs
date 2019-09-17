using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnCall.Service.Domain.Ext;
using OnCall.Service.Domain.Entity;
using OnCall.Service.Domain.Enum;
using OnCall.Service.Domain.Job.JobDataHandle;
using System.Threading.Tasks;

namespace OnCall.Service.Domain.Job
{
    /// <summary>
    /// 升压站监控变位告警
    /// 一级变位告警代表最严重，会引起负荷的大量损失，引起电网波动，有可能造成人身事故和设备严重损坏安全事故的；
    /// 二级变位告警代表必须停机或者停电 进行检修和维护的，需要更换备件的；
    /// 三级变位告警代表可以进行自复位或者可以人为的进 行远程复位以及就地复位故障，或自身出现告警信号和报警但是并不影响正常运行的。
    ///
    /// 可将短信发送设置为
    /// 一级变位告警直接发送至区域新能源公司生 产分管领导；
    /// 二级变位告警发送至生产部门负责人；
    /// 三级变位告警发送至现场运维检修人员 与集控中心运行值班人员，【具体各级变位告警的发送情况可根据用户实际需要进行调整】
    /// 
    /// 该Job职责：从【遥信变位事件历史库】抓报警数据新增/分解到【OnCall->MessageQueue】消息队列表
    /// 
    /// 处理明细
    /// 1、等级干预处理
    /// 2、根据【报警级别】[XX有人工干预级别] 找出对于人员(每人一行记录)
    /// 3、关键字替换
    /// 4、添加表【OnCall->MessageQueue】
    /// 
    /// AlarmType ：报警类型：1:机组报警，2:变位报警，3:人工Web群发消息报警
    /// MessageType：消息类型WeChat/SMS/Web
    /// </summary>
    public class AlarmVariableBitJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {

            Task.Factory.StartNew(() =>
            {
                try
                {
                    //一次Job的告警数量
                    var listVarBitAlarm = JobDbAssist.Instance.GetNewAlarmVariableBit();

                    if (listVarBitAlarm.Count() > 0)
                    {
                        JobDbAssist.Instance.VBitAlarmLastTime = DateTime.Now;

                        //更新变位告警数量
                        JobDispatch.UIVBitCount?.Invoke(listVarBitAlarm.Count());

                        foreach (E遥信变位事件历史库 item in listVarBitAlarm)
                        {
                            //按等级获取不同用户【发送到对应等级用户】，插入到MessageQueue
                            var alarmLeveUsers = JobDbAssist.Instance.GetUserInfoByLevel(item.等级, (int)eAlarmType.VariableBitAlarm);//等级用户

                            foreach (VAlarmLevelUser itemUser in alarmLeveUsers)//几个用户几行报警
                            {
                                JobDataBuilder.Instance.BuilderMessageData_SMSAlarmVariableBit(item, itemUser);//短信报警
                                JobDataBuilder.Instance.BuilderMessageData_WeChatAlarmVariableBit(item, itemUser);//微信报警
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log.WriteFormat("D-【AlarmVariableBitJob】Job异常：{0}", ex.Message);
                    JobDispatch.UIDispalyTask("{0} 【获取变位告警Job异常】".Format(context.JobDetail.Key.Name), ex.Message, 2);
                    //throw;
                }

            });

        }
    }
}
