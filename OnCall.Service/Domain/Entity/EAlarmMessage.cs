using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Job.Entity
{
    /// <summary>
    /// 告警消息实体
    /// 告警类型:${AlarmType}\n厂站ID:${StationID}\n告警等级:${AlarmLevel}\n状态:${Status}\n告警内容:${AlarmContent}\n告警时间:${CreateTime}
    /// </summary>
    public class EAlarmMessage
    {
        /// <summary>
        /// 告警类型  风电机组故障告警/升压站监控变位告警
        /// </summary>
        public string AlarmType { get; set; }
        /// <summary>
        /// 厂站ID
        /// </summary>
        public string StationID { get; set; }
        /// <summary>
        /// 告警等级
        /// </summary>
        public string AlarmLevel { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 告警时间
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 报警内容
        /// </summary>
        public string AlarmContent { get; set; }
    }
}
