using OnCall.Service.Domain.Entity;
using OnCall.Service.Domain.Enum;
using OnCall.Service.Domain.Ext;
using OnCall.Service.Domain.Job.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Job.JobDataHandle
{
    /// <summary>
    /// 该类职责：组装Job中所需数据
    /// </summary>
    public class JobDataBuilder
    {
        private static JobDataBuilder _JobDataBuilder;

        public static JobDataBuilder Instance
        {
            get
            {
                if (_JobDataBuilder == null)
                {
                    _JobDataBuilder = new JobDataBuilder();
                }
                return _JobDataBuilder;
            }
        }

        #region 风电机组故障告警
        /// <summary>
        /// 组装MessageQueue数据 风电机组故障告警 SMS
        /// </summary>
        public int BuilderMessageData_SMSAlarmCrew(E故障事件历史库 alarm, VAlarmLevelUser user)
        {

            int resultId = 0;
            try
            {

                EMessageQueue mQueue = new EMessageQueue();

                mQueue.AlarmLevel = alarm.等级;
                mQueue.CreateTime = DateTime.Now;
                mQueue.MessageContent = BuilderSMSAlarmCrew(alarm).ToJson();
                mQueue.Status = (int)eSendStatus.WaitSend;//等待发送
                mQueue.OpenId = user.OpenId;
                mQueue.MessageType = (int)eMessageType.SMS;
                mQueue.Mobile = user.Mobile;
                mQueue.AlarmType = (int)eAlarmType.CrewAlarm;
                mQueue.FaultCount = 0;
                mQueue.UserID = user.UserID;
                mQueue.MessageData = alarm.ToJson();

                resultId = JobDbAssist.Instance.InsertMessageQueue(mQueue);

            }
            catch (Exception ex)
            {
                Log.WriteFormat("C-【BuilderMessageData_SMSAlarmCrew】Job异常：{0}", ex.Message);
                JobDispatch.UIDispalyTask("【风电机组故障告警Builder异常】JobDataBuilder.BuilderMessageData_SMSAlarmCrew", ex.Message, (int)eJobStatus.Exception);
            }
            return resultId;
        }
        /// <summary>
        /// 组装MessageQueue数据 风电机组故障告警 WeChat
        /// </summary>
        public int BuilderMessageData_WeChatAlarmCrew(E故障事件历史库 alarm, VAlarmLevelUser user)
        {

            int resultId = 0;
            try
            {

                EMessageQueue mQueue = new EMessageQueue();

                mQueue.AlarmLevel = alarm.等级;
                mQueue.CreateTime = DateTime.Now;
                mQueue.MessageContent = BuilderSMSAlarmCrew(alarm).ToJson();
                mQueue.Status = (int)eSendStatus.WaitSend;//等待发送
                mQueue.OpenId = user.OpenId;
                mQueue.MessageType = (int)eMessageType.WeChat;
                mQueue.Mobile = user.Mobile;
                mQueue.AlarmType = (int)eAlarmType.CrewAlarm;
                mQueue.FaultCount = 0;
                mQueue.UserID = user.UserID;
                mQueue.MessageData = alarm.ToJson();

                resultId = JobDbAssist.Instance.InsertMessageQueue(mQueue);

            }
            catch (Exception ex)
            {
                Log.WriteFormat("C-【BuilderMessageData_WeChatAlarmCrew】Job异常：{0}", ex.Message);
                JobDispatch.UIDispalyTask("【风电机组故障告警Builder异常】JobDataBuilder.BuilderMessageData_WeChatAlarmCrew", ex.Message, (int)eJobStatus.Exception);
            }
            return resultId;
        }

        public EAlarmMessage BuilderSMSAlarmCrew(E故障事件历史库 item)
        {
            EAlarmMessage smsAlarmTemp = new EAlarmMessage();
            smsAlarmTemp.AlarmLevel = item.等级.ToString();
            smsAlarmTemp.AlarmType = "风电机组故障告警";
            smsAlarmTemp.CreateTime = DateTime.Now.ToDateTime2();
            smsAlarmTemp.StationID = item.厂站ID;
            smsAlarmTemp.Status = item.状态;
            return smsAlarmTemp;
        }
        #endregion

        #region 升压站监控变位告警
        /// <summary>
        /// 组装MessageQueue数据 升压站监控变位告警 SMS
        /// </summary>
        public int BuilderMessageData_SMSAlarmVariableBit(E遥信变位事件历史库 alarm, VAlarmLevelUser user)
        {

            int resultId = 0;
            try
            {

                EMessageQueue mQueue = new EMessageQueue();

                mQueue.AlarmLevel = alarm.等级;
                mQueue.CreateTime = DateTime.Now;
                mQueue.MessageContent = BuilderSMSAlarmVariableBit(alarm).ToJson();
                mQueue.Status = (int)eSendStatus.WaitSend;//等待发送
                mQueue.OpenId = user.OpenId;
                mQueue.MessageType = (int)eMessageType.SMS;
                mQueue.Mobile = user.Mobile;
                mQueue.AlarmType = (int)eAlarmType.VariableBitAlarm;
                mQueue.FaultCount = 0;
                mQueue.UserID = user.UserID;
                mQueue.MessageData = alarm.ToJson();

                resultId = JobDbAssist.Instance.InsertMessageQueue(mQueue);

            }
            catch (Exception ex)
            {
                Log.WriteFormat("C-【BuilderMessageData_SMSAlarmVariableBit】Job异常：{0}", ex.Message);
                JobDispatch.UIDispalyTask("【升压站监控变位告警Builder异常】JobDataBuilder.BuilderMessageData_SMSAlarmVariableBit", ex.Message, (int)eJobStatus.Exception);
            }
            return resultId;
        }
        /// <summary>
        /// 组装MessageQueue数据 升压站监控变位告警 WeChat
        /// </summary>
        public int BuilderMessageData_WeChatAlarmVariableBit(E遥信变位事件历史库 alarm, VAlarmLevelUser user)
        {

            int resultId = 0;
            try
            {

                EMessageQueue mQueue = new EMessageQueue();

                mQueue.AlarmLevel = alarm.等级;
                mQueue.CreateTime = DateTime.Now;
                mQueue.MessageContent = BuilderSMSAlarmVariableBit(alarm).ToJson();
                mQueue.Status = (int)eSendStatus.WaitSend;//等待发送
                mQueue.OpenId = user.OpenId;
                mQueue.MessageType = (int)eMessageType.WeChat;
                mQueue.Mobile = user.Mobile;
                mQueue.AlarmType = (int)eAlarmType.VariableBitAlarm;
                mQueue.FaultCount = 0;
                mQueue.UserID = user.UserID;
                mQueue.MessageData = alarm.ToJson();

                resultId = JobDbAssist.Instance.InsertMessageQueue(mQueue);

            }
            catch (Exception ex)
            {
                Log.WriteFormat("C-【BuilderMessageData_WeChatAlarmVariableBit】Job异常：{0}", ex.Message);
                JobDispatch.UIDispalyTask("【升压站监控变位告警Builder异常】JobDataBuilder.BuilderMessageData_WeChatAlarmVariableBit", ex.Message, (int)eJobStatus.Exception);
            }
            return resultId;
        }

        public EAlarmMessage BuilderSMSAlarmVariableBit(E遥信变位事件历史库 item)
        {
            EAlarmMessage smsAlarmTemp = new EAlarmMessage();
            smsAlarmTemp.AlarmLevel = item.等级.ToString();
            smsAlarmTemp.AlarmType = "升压站监控变位告警";
            smsAlarmTemp.CreateTime = DateTime.Now.ToDateTime2();
            smsAlarmTemp.StationID = item.厂站ID;
            smsAlarmTemp.Status = item.状态;
            return smsAlarmTemp;
        }
        #endregion


    }
}
