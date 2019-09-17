using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Entity
{
    public class E故障事件历史库
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
        /// 标识
        ///</summary>
        public string 标识 { get; set; }
        ///<summary>
        /// 描述
        ///</summary>
        public string 描述 { get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public string 状态 { get; set; }
        ///<summary>
        /// 设备标识
        ///</summary>
        public string 设备标识 { get; set; }
        ///<summary>
        /// 等级
        ///</summary>
        public int 等级 { get; set; }
        ///<summary>
        /// 风机类型
        ///</summary>
        public string 风机类型 { get; set; }
        ///<summary>
        /// 风机标识
        ///</summary>
        public string 风机标识 { get; set; }
        ///<summary>
        /// 起始时间
        ///</summary>
        public DateTime? 起始时间 { get; set; }
        ///<summary>
        /// 结束时间
        ///</summary>
        public DateTime? 结束时间 { get; set; }
        ///<summary>
        /// 处理标识
        ///</summary>
        public int 处理标识 { get; set; }
        ///<summary>
        /// 操作指导
        ///</summary>
        public string 操作指导 { get; set; }
        ///<summary>
        /// 备注
        ///</summary>
        public string 备注 { get; set; }
    }

}
