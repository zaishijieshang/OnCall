using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Entity
{
    public class ESysUserInfo
    {

        ///<summary>
        /// UserID
        ///</summary>
        public int UserID { get; set; }
        ///<summary>
        /// 用户名
        ///</summary>
        public string UserName { get; set; }
        ///<summary>
        /// 真实姓名
        ///</summary>
        public string RealName { get; set; }
        ///<summary>
        /// 密码
        ///</summary>
        public string Pwd { get; set; }
        ///<summary>
        /// 手机号
        ///</summary>
        public string Mobile { get; set; }
        ///<summary>
        /// 微信号
        ///</summary>
        public string Wechat { get; set; }
        ///<summary>
        /// 邮箱
        ///</summary>
        public string Email { get; set; }
        ///<summary>
        /// OpenID
        ///</summary>
        public string OpenId { get; set; }
        ///<summary>
        /// 部门
        ///</summary>
        public string Dept { get; set; }
        ///<summary>
        /// 岗位
        ///</summary>
        public string Position { get; set; }
        ///<summary>
        /// 备注
        ///</summary>
        public string Mark { get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public int Status { get; set; }
    }

    public class VAlarmLevelUser
    {
        ///<summary>
        /// 真实姓名
        ///</summary>
        public string RealName { get; set; }
        ///<summary>
        /// 手机号
        ///</summary>
        public string Mobile { get; set; }
        ///<summary>
        /// 邮箱
        ///</summary>
        public string Email { get; set; }
        ///<summary>
        /// OpenID
        ///</summary>
        public string OpenId { get; set; }
        /// <summary>
        /// UserID
        /// </summary>
        public int UserID { get; set; }
    }
}
