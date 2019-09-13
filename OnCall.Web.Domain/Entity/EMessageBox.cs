using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Entity
{
    public class EMessageBox
    {

        ///<summary>
        /// ID
        ///</summary>
        public int ID { get; set; }
        ///<summary>
        /// 发件人
        ///</summary>
        public string Sender { get; set; }
        ///<summary>
        /// 发送人ID
        ///</summary>
        public int SenderID { get; set; }
        ///<summary>
        /// 收件人
        ///</summary>
        public string Receiver { get; set; }
        ///<summary>
        /// 接收人ID
        ///</summary>
        public int ReceiverID { get; set; }
        ///<summary>
        /// 发送时间
        ///</summary>
        public DateTime? SendTime { get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime { get; set; }
        ///<summary>
        /// 标题
        ///</summary>
        public string Title { get; set; }
        ///<summary>
        /// 内容
        ///</summary>
        public string Content { get; set; }
        ///<summary>
        /// 1:收件箱 2:发件箱 3:草稿箱
        ///</summary>
        public int Type { get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public int Status { get; set; }
    }

}
