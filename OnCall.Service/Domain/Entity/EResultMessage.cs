using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Entity
{
    /// <summary>
    /// 消息发送反馈实体
    /// </summary>
    public class EResultMessage
    {
        public string Message { get;set;}
        public string RequestId { get;set; }
        public string BizId { get;set; }
        public string Code { get;set; }
    }
}
