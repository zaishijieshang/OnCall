using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Entity
{
    public class ESysRole
    {

        ///<summary>
        /// 角色ID
        ///</summary>
        public int RoleID { get; set; }
        ///<summary>
        /// 角色名称
        ///</summary>
        public string RoleName { get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public int Status { get; set; }
        ///<summary>
        /// 描述
        ///</summary>
        public string Mark { get; set; }
    }

}
