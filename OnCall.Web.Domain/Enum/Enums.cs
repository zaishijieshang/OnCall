using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Enum
{
    /// <summary>
    /// 报警类型
    /// </summary>
    public enum enAlarmLevelType
    {
        /// <summary>
        /// 风电机组故障告警
        /// </summary>
        AlarmCrewLevel = 1,
        /// <summary>
        /// 升压站监控变位告警
        /// </summary>
        AlarmVariableBitLevel = 2
    }
}
