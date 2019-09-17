using Newtonsoft.Json;
using OnCall.Service.Domain.Entity;
using OnCall.Service.Domain.Enum;
using OnCall.Service.Domain.Job.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Ext
{
    public static class GeneralExtensions
    {
        public static string Format(this string str, params object[] args)
        {
            return string.Format(str, args);
        }
        public static string ObjectToString(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        public static string ToDateTime2(this DateTime obj)
        {
            if (obj != null)
                return obj.ToString("yyyy-MM-dd HH:mm:ss");
            return obj.ToString();
        }
        public static string ToJobStatus(this int status)
        {
            string StatusStr = string.Empty;
            switch (status)
            {
                case 0: StatusStr = "OK"; break;
                case 1: StatusStr = "Fault"; break;
                case 2: StatusStr = "Exception"; break;
            }
            return StatusStr;
        }

        public static EAlarmData ToAmarlData(this E故障事件历史库 eAlarm)
        {
            EAlarmData reAlarm = new EAlarmData();
            reAlarm.AlarmContent = eAlarm.描述;
            reAlarm.ExeTime = DateTime.Now;
            reAlarm.StationTitle = eAlarm.厂站ID;
            reAlarm.AlarmLevel = eAlarm.等级.ToString();
            reAlarm.Status = eAlarm.状态;
            return reAlarm;
        }




    }
}
