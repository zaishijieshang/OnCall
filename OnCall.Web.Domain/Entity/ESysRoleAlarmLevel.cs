using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Entity
{
    public class ESysRoleAlarmLevel
    {

        ///<summary>
        /// 角色ID
        ///</summary>
        public int RoleID { get; set; }
        ///<summary>
        /// 级别
        ///</summary>
        public int AlarmLevel { get; set; }
        ///<summary>
        /// 报警类别:1:机组报警，2:变位报警，3:人工Web群发消息报警
        ///</summary>
        public int AlarmType { get; set; }
    }




}
