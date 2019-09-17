using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Entity
{
    public class E遥信变位事件历史库
    {

        ///<summary>
        /// ID_KEY
        ///</summary>
        public int ID_KEY { get; set; }
        ///<summary>
        /// 厂站ID
        ///</summary>
        public string 厂站ID { get; set; }
        ///<summary>
        /// YXID 标识
        ///</summary>
        public string YXID { get; set; }
        ///<summary>
        /// 值名
        ///</summary>
        public string 值名 { get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public string 状态 { get; set; }
        ///<summary>
        /// 时间
        ///</summary>
        public DateTime? 时间 { get; set; }
        ///<summary>
        /// 毫秒
        ///</summary>
        public string 毫秒 { get; set; }
        ///<summary>
        /// comflag
        ///</summary>
        public int comflag { get; set; }
        ///<summary>
        /// 备注
        ///</summary>
        public string 备注 { get; set; }
        ///<summary>
        /// 等级
        ///</summary>
        public int 等级 { get; set; }
    }

}
