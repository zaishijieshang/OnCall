using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Entity
{
    public class ESysAlarmLevel
    {

        ///<summary>
        /// ID
        ///</summary>
        public int ID { get; set; }
        ///<summary>
        /// 等级
        ///</summary>
        public string AlarmLevel { get; set; }
        ///<summary>
        /// 类别:1:机组报警，2:变位报警，3:人工Web群发消息报警
        ///</summary>
        public int AlarmType { get; set; }
        /// <summary>
        /// 实际等级标识(【重要】与报警等级一至)
        /// </summary>
        public int iAlarmLevel { get; set; }

        
    }

}
