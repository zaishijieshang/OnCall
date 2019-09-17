using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using OnCall.Service.Domain.Entity;

namespace OnCall.Service.Domain
{
    /// <summary>
    /// Job 查询数据库的支持类
    /// </summary>
    public class JobDbAssist
    {

        private static JobDbAssist _JobDbAssist;

        public static JobDbAssist Instance
        {
            get
            {
                if (_JobDbAssist == null)
                {
                    _JobDbAssist = new JobDbAssist();
                }
                return _JobDbAssist;
            }
        }

        /// <summary>
        /// 风电机组故障告警MaxID【废弃】
        /// </summary>
        //public int AlarmCrewLevelMaxID
        //{
        //    get
        //    {
        //        using (var db = DB.DBConnection)
        //        {
        //            string sql = "select top 1 AlarmCrew from AlarmMaxID where ID=1";
        //            return db.Query<int>(sql).FirstOrDefault();
        //        }
        //    }
        //}
        ///// <summary>
        ///// 升压站监控变位告警MaxID【废弃】
        ///// </summary>
        //public int AlarmVariableBitMaxID
        //{
        //    get
        //    {
        //        using (var db = DB.DBConnection)
        //        {
        //            string sql = "select top 1 AlarmVariableBit from AlarmMaxID where ID=1";
        //            return db.Query<int>(sql).FirstOrDefault();
        //        }
        //    }
        //}

        /// <summary>
        /// 服务程序启动是检查【废弃】
        ///bool CheckMaxID = JobDbAssist.Instance.CheckAlarmMaxID();//检查/设置报警最大MAxID
        /// </summary>
        /// <returns></returns>
        //public bool CheckAlarmMaxID()
        //{
        //    bool flag = false;
        //    try
        //    {
        //        int alarmCrewMaxId = 0;
        //        int alarmVariableBitMaxId = 0;
        //        using (var db = DB.AlarmDBConnection)
        //        {
        //            string sql = "select top 1 AlarmCrew from AlarmMaxID where ID=1";
        //            alarmCrewMaxId = db.Query<int>(sql).FirstOrDefault();
        //            if (alarmCrewMaxId == 0)
        //            {
        //                sql = "select MAX(ID_KEY)  maxId from 故障事件历史库";
        //                alarmCrewMaxId = db.Query<int>(sql).FirstOrDefault();
        //            }

        //            sql = "select top 1 AlarmVariableBit from AlarmMaxID where ID=1";
        //            alarmVariableBitMaxId = db.Query<int>(sql).FirstOrDefault();
        //            if (alarmVariableBitMaxId == 0)
        //            {
        //                sql = "select MAX(ID_KEY)  maxId from 遥信变位事件历史库";
        //                alarmVariableBitMaxId = db.Query<int>(sql).FirstOrDefault();
        //            }
        //        }

        //        //从启动以后的记录开始获取报警
        //        if (alarmCrewMaxId > 0 && alarmVariableBitMaxId > 0)
        //        {
        //            using (var db = DB.DBConnection)
        //            {
        //                string sql = "update AlarmCrew=@AlarmCrew,AlarmVariableBit=@AlarmVariableBit where ID=1";
        //                flag = db.Execute(sql, new { AlarmCrew = alarmCrewMaxId, AlarmVariableBit = alarmVariableBitMaxId }) > 0;
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Log.WriteFormat("B-【CheckAlarmMaxID】异常：{0}", ex.Message);
        //        JobDispatch.UIDispalyTask("【CheckAlarmMaxID异常】", ex.Message, 2);
        //        //throw ex;
        //    }

        //    return flag;
        //}

        /// <summary>
        /// 获取风电机组故障【最新告警数据】【废弃】
        /// </summary>
        //public IEnumerable<E故障事件历史库> GetNewAlarmCrewLevel_废弃()
        //{
        //    using (var db = DB.AlarmDBConnection)
        //    {
        //        string sql = "select * from 故障事件历史库 where ID_KEY>@MaxID";
        //        return db.Query<E故障事件历史库>(sql, new { MaxID = AlarmCrewLevelMaxID });
        //    }
        //}

        /// <summary>
        /// 升压站监控变位告警【最新告警数据】【废弃】
        /// </summary>
        //public IEnumerable<E遥信变位事件历史库> GetNewAlarmVariableBit()
        //{
        //    using (var db = DB.AlarmDBConnection)
        //    {
        //        string sql = "select * from 遥信变位事件历史库 where ID_KEY>@MaxID";
        //        return db.Query<E遥信变位事件历史库>(sql, new { MaxID = AlarmVariableBitMaxID });
        //    }
        //}

        public DateTime VBitAlarmLastTime
        {
            get
            {
                using (var db = DB.DBConnection)
                {
                    string sql = "select top 1 VBitLastTime from AlarmLastTime where ID=1";
                    return db.Query<DateTime>(sql).FirstOrDefault();
                }
            }
            set
            {
                using (var db = DB.DBConnection)
                {
                    string sql = "update AlarmLastTime set VBitLastTime=@VBitLastTime where ID=1";
                    db.Execute(sql, new { CrewLastTime = value });
                }
            }
        }

        public DateTime CrewLastStartTime
        {
            get
            {
                using (var db = DB.DBConnection) 
                {
                    string sql = "select top 1 CrewLastStartTime from AlarmLastTime where ID=1";
                    return db.Query<DateTime>(sql).FirstOrDefault();
                }
            }
            set
            {
                using (var db = DB.DBConnection)
                {
                    string sql = "update AlarmLastTime set CrewLastStartTime=@CrewLastStartTime where ID=1";
                    db.Execute(sql, new { CrewLastStartTime = value });
                }
            }
        }

        public DateTime CrewLastEndTime
        {
            get
            {
                using (var db = DB.DBConnection)
                {
                    string sql = "select top 1 CrewLastEndTime from AlarmLastTime where ID=1";
                    return db.Query<DateTime>(sql).FirstOrDefault();
                }
            }
            set
            {
                using (var db = DB.DBConnection)
                {
                    string sql = "update AlarmLastTime set CrewLastEndTime=@CrewLastEndTime where ID=1";
                    db.Execute(sql, new { CrewLastEndTime = value });
                }
            }
        }

        /// <summary>
        /// 新的变位报警
        /// </summary>
        /// <returns></returns>
        public IEnumerable<E遥信变位事件历史库> GetNewAlarmVariableBit()
        {
            using (var db = DB.AlarmDBConnection)
            {
                string sql = "select * from 遥信变位事件历史库 where 时间>@LastTime";
                return db.Query<E遥信变位事件历史库>(sql, new { LastTime = VBitAlarmLastTime });
            }
        }


        /// <summary>
        /// 新的机组故障 开始报警时间
        /// </summary>
        /// <returns></returns>
        public IEnumerable<E故障事件历史库> GetNewStartAlarmCrewLevel()
        {
            using (var db = DB.AlarmDBConnection)
            {
                string sql = "select * from 故障事件历史库 where 起始时间>@LastStartTime";
                return db.Query<E故障事件历史库>(sql, new { LastStartTime = CrewLastStartTime });
            }
        }
        /// <summary>
        /// 新的机组故障  结束报警时间
        /// </summary>
        /// <returns></returns>
        public IEnumerable<E故障事件历史库> GetNewEndAlarmCrewLevel()
        {
            using (var db = DB.AlarmDBConnection)
            {
                string sql = "select * from 故障事件历史库 where 结束时间>@LastEndTime";
                return db.Query<E故障事件历史库>(sql, new { LastEndTime = CrewLastEndTime });
            }
        }



        /// <summary>
        /// 按角色告警等级获取用户 
        /// 【Sys_AlarmLevel->iAlarmLevel】 是实际对应生成库的等级
        /// </summary>
        /// <returns></returns>
        public IEnumerable<VAlarmLevelUser> GetUserInfoByLevel(int AlarmLevel, int AlarmType)
        {
            using (var db = DB.AlarmDBConnection)
            {
                string sql = @"select ui.UserID,RealName,Mobile,Email,OpenId from Sys_RoleAlarmLevel ral
                                            inner join Sys_UserRole ur on ral.RoleID = ur.RoleID
                                            inner join Sys_UserInfo ui on ur.UserID = ur.UserID
                                            inner join Sys_AlarmLevel al on ral.AlarmLevel = al.ID
                                            where al.iAlarmLevel = @AlarmLevel and ral.AlarmType=@AlarmType and ui.Status = 1";
                return db.Query<VAlarmLevelUser>(sql, new { AlarmLevel = AlarmLevel, AlarmType = AlarmType });
            }
        }

        /// <summary>
        /// 已处理的数据 插入到发送队列
        /// </summary>
        /// <returns></returns>
        public int InsertMessageQueue(EMessageQueue eMessageQueue)
        {
            using (var db = DB.AlarmDBConnection)
            {
                string sql = "insert into MessageQueue(MessageContent,AlarmLevel,MessageType,AlarmType," +
                    "MessageData,Mobile,OpenId,CreateTime,FaultCount,Status,ResultMessage)" +
                    " values(@MessageContent,@AlarmLevel,@MessageType,@AlarmType," +
                    "@MessageData,@Mobile,@OpenId,@CreateTime,@FaultCount,@Status,@ResultMessage);" +
                    "select @@Identity;";

                return db.ExecuteScalar<int>(sql, eMessageQueue);
            }
        }


        /// <summary>
        /// 获取待发送数据
        ///MessageType 消息类型:1SMS/2WeChat/3Web
        ///AlarmType 报警类型：1:机组报警，2:变位报警，3:人工群发消息报警
        ///状态  0发送失败，1发送成功，2发送中，3等待发送
        /// </summary>
        /// <returns></returns>
        public IEnumerable<VMessageQueye> GetWaitSendMessageQueue(int MessageType)
        {
            using (var db = DB.AlarmDBConnection)
            {
                string sql = @"select  ID,MessageContent ,AlarmLevel ,MessageType, AlarmType,Mobile OpenId MessageQueue 
                                          where MessageType=@MessageType and Status=3
                                           order by AlarmLevel asc";
                return db.Query<VMessageQueye>(sql, new { MessageType = MessageType });
            }
        }
        /// <summary>
        /// 获取待发送过，但是发送失败被留下的数据
        /// 状态  0发送失败，1发送成功，2发送中，3等待发送
        /// 发送失败大于5次将被清理掉
        /// </summary>
        /// <returns></returns>
        public IEnumerable<VMessageQueye> GetWaitAgainSendMessageQueue(int MessageType)
        {
            using (var db = DB.AlarmDBConnection)
            {
                string sql = @"select  ID,MessageContent ,AlarmLevel ,MessageType, AlarmType,Mobile OpenId MessageQueue 
                                          where MessageType=@MessageType and Status=0 and FaultCount<=5
                                           order by AlarmLevel asc";
                return db.Query<VMessageQueye>(sql, new { MessageType = MessageType });
            }
        }



        public bool SetSMSMessageQueueStatus(int ID, int Status)
        {
            using (var db = DB.AlarmDBConnection)
            {
                string sql = "update MessageQueue set Status=@Status where ID=@ID";
                return db.Execute(sql, new { ID = ID, Status = Status }) > 0;
            }
        }

        /// <summary>
        /// 更新发送反馈并Fault++,并设置状态
        /// 状态  0发送失败，1发送成功，2发送中，3等待发送
        /// </summary>
        /// <returns></returns>
        public bool SetSMSResultSendMessageQueue(int ID, string ResultMessage, bool isSuccess)
        {
            using (var db = DB.AlarmDBConnection)
            {
                string sql = "update MessageQueue set ResultMessage=@ResultMessage,Status=0,FaultCount=FaultCount+1 where ID=@ID";
                if (isSuccess)
                {
                    sql = "update MessageQueue set ResultMessage=@ResultMessage,Status=1 where ID=@ID";
                }
                return db.Execute(sql, new { ResultMessage = ResultMessage, ID = ID }) > 0;
            }
        }



    }
}
