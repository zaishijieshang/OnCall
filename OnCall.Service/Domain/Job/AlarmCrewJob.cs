using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnCall.Service.Domain.Ext;
using OnCall.Service.Domain.Entity;
using OnCall.Service.Domain.Job.Entity;
using OnCall.Service.Domain.Job.JobDataHandle;
using OnCall.Service.Domain.Enum;
using System.Threading.Tasks;

namespace OnCall.Service.Domain.Job
{
    /// <summary>
    /// 风电机组故障告警 Job
    /// 
    /// 新能源远程集控平台结合底层风机监控系统采集的实时数据，将风电机组所有故障报警信息共分为四级，其中
    /// 一级故障代表危及风电机安全、导致风电机紧急停机，发生后必须关注优先处理的故障；
    /// 二级故障代表导致一般或快速停机，可能导致风电机部件的损坏的，无法通过风电机自动复位系统即可自行消除的，需要人为干预消除的故障；
    /// 三级故障代表影响 风电机出力，无法通过风电机自动复位系统即可自行消除的，需要正常停机后人为干预消除 的故障；
    /// 四级故障代表一般的告警信号，发生后不影响风电机出力，通过风电机自动复位系 统即可自行消除的故障，不需要人为干预。
    /// 
    /// 该Job职责：从【故障事件历史库】抓报警数据新增/分解到【OnCall->MessageQueue】消息队列表
    /// 
    /// 可将短信发送设置为
    /// 一级故障直接发送至区域新能源公司生产分管领导；
    /// 二级故障发送至生产部门负责人【角色里设置用户人即可】；
    /// 三级故障发 送至现场运维检修人员；
    /// 四级故障发送至运行值班人员，【具体各级故障的发送情况可根据用 户实际需要进行调整。】
    /// 
    /// 处理明细
    /// 1、等级干预处理
    /// 2、根据【报警级别】[XX有人工干预级别] 找出对于人员(每人一行记录)【要到用户报警定义表搂一遍】
    /// 3、关键字替换
    /// 4、添加表【OnCall->MessageQueue】
    /// 
    /// AlarmType ：报警类型：1:机组报警，2:变位报警，3:人工Web群发消息报警
    /// MessageType：消息类型 WeChat/SMS/Web
    /// </summary>
    public class AlarmCrewJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {

            Task.Factory.StartNew(() =>
            {

                try
                {
                    //一次Job的告警数量
                    var listStartAlarm = JobDbAssist.Instance.GetNewStartAlarmCrewLevel();   //故障开始报警时间

                    if (listStartAlarm.Count() > 0)
                    {
                        JobDbAssist.Instance.CrewLastStartTime = DateTime.Now;//最后报警开始时间更新为当前时间

                        //更新告警数量
                        JobDispatch.UIFaultAlarmCount?.Invoke(listStartAlarm.Count());

                        foreach (E故障事件历史库 item in listStartAlarm)
                        {
                            //更新UI告警
                            JobDispatch.UIExeAlarmData?.Invoke(item.ToAmarlData());

                            //按等级获取不同用户，插入到MessageQueue
                            var alarmLeveUsers = JobDbAssist.Instance.GetUserInfoByLevel(item.等级, (int)eAlarmType.CrewAlarm);//等级用户

                            foreach (VAlarmLevelUser itemUser in alarmLeveUsers)//几个用户几行报警
                            {
                                JobDataBuilder.Instance.BuilderMessageData_SMSAlarmCrew(item, itemUser);//短信报警
                                JobDataBuilder.Instance.BuilderMessageData_WeChatAlarmCrew(item, itemUser);//微信报警
                            }

                        }

                    }

                    //一次Job的告警数量
                    var listEndAlarm = JobDbAssist.Instance.GetNewEndAlarmCrewLevel();   //故障结束报警时间

                    if (listEndAlarm.Count() > 0)
                    {
                        JobDbAssist.Instance.CrewLastEndTime = DateTime.Now;//最后报警结束时间更新为当前时间

                        //更新告警数量
                        JobDispatch.UIFaultAlarmCount?.Invoke(listEndAlarm.Count());

                        foreach (E故障事件历史库 item in listEndAlarm)
                        {
                            //更新UI告警
                            JobDispatch.UIExeAlarmData?.Invoke(item.ToAmarlData());

                            //按等级获取不同用户【发送到对应等级用户】，插入到MessageQueue
                            var alarmLeveUsers = JobDbAssist.Instance.GetUserInfoByLevel(item.等级, (int)eAlarmType.CrewAlarm);//等级用户

                            foreach (VAlarmLevelUser itemUser in alarmLeveUsers)//几个用户几行报警
                            {
                                JobDataBuilder.Instance.BuilderMessageData_SMSAlarmCrew(item, itemUser);//短信报警
                                JobDataBuilder.Instance.BuilderMessageData_WeChatAlarmCrew(item, itemUser);//微信报警
                            }

                        }

                    }


                }
                catch (Exception ex)
                {
                    Log.WriteFormat("A-【AlarmCrewJob】Job异常：{0}", ex.Message);
                    JobDispatch.UIDispalyTask("{0} 【获取故障告警Job异常】".Format(context.JobDetail.Key.Name), ex.Message, 2);
                    //throw ex;
                }

            });


        }
    }


}
