using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Entity
{
    public class ESysUserRole
    {

        ///<summary>
        /// ID
        ///</summary>
        public int ID { get; set; }
        ///<summary>
        /// 角色ID
        ///</summary>
        public int RoleID { get; set; }
        ///<summary>
        /// 用户ID
        ///</summary>
        public int UserID { get; set; }
        ///<summary>
        /// 用户名Selector-Sys_UserInfo
        ///</summary>
        public string UserName { get; set; }
    }

}
