using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Entity
{
    public class EMessageQueue
    {

        ///<summary>
        /// ID
        ///</summary>
        public int ID { get; set; }
        ///<summary>
        /// 消息内容
        ///</summary>
        public string MessageContent { get; set; }
        ///<summary>
        /// 告警级别
        ///</summary>
        public int AlarmLevel { get; set; }
        ///<summary>
        /// 消息类型:1SMS/2WeChat/3Web
        ///</summary>
        public int MessageType { get; set; }
        ///<summary>
        /// 报警类型：1:机组报警，2:变位报警，3:人工群发消息报警
        ///</summary>
        public int AlarmType { get; set; }
        ///<summary>
        /// 消息JSON数据
        ///</summary>
        public string MessageData { get; set; }
        ///<summary>
        /// 接收人手机号
        ///</summary>
        public string Mobile { get; set; }
        ///<summary>
        /// 接收人OpenId
        ///</summary>
        public string OpenId { get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime { get; set; }
        ///<summary>
        /// 发送异常次数
        ///</summary>
        public int FaultCount { get; set; }
        ///<summary>
        /// 状态  0发送失败，1发送成功，2发送中，3等待发送
        ///</summary>
        public int Status { get; set; }
        ///<summary>
        /// 发送反馈消息
        ///</summary>
        public string ResultMessage { get; set; }
        ///<summary>
        /// 用户ID
        ///</summary>
        public int UserID { get; set; }
    }


}
