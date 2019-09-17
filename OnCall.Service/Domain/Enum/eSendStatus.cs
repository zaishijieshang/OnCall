using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Enum
{
    public enum eSendStatus
    {
        /// <summary>
        /// 发送失败
        /// </summary>
        Fail = 0,
        /// <summary>
        /// 发送成功
        /// </summary>
        Success = 1,
        /// <summary>
        /// 发送中
        /// </summary>
        Sending = 2,
        /// <summary>
        /// 等待发送
        /// </summary>
        WaitSend = 3

    }

    /// <summary>
    /// 报警类型：1:机组报警，2:变位报警，3:人工群发消息报警
    /// </summary>
    public enum eAlarmType
    {
        CrewAlarm = 1,
        VariableBitAlarm = 2,
        Web = 3
    }

    public enum eMessageType
    {
        SMS = 1,
        WeChat = 2,
        Web = 3
    }

    public enum eJobStatus
    {
        OK=0,
        Fault=1,
        Exception=2
    }

}
