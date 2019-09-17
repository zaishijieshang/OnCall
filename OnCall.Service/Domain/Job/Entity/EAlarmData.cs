using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Job.Entity
{
    public class EAlarmData
    {
        public DateTime ExeTime { get; set; }
        /// <summary>
        /// 告警厂站
        /// </summary>
        public string StationTitle { get; set; }

        /// <summary>
        /// 告警内容
        /// </summary>
        public string AlarmContent { get; set; }
        /// <summary>
        /// 告警级别
        /// </summary>
        public string AlarmLevel { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }
    }
}
