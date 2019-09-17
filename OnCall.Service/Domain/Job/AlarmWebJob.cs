using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Job
{

    /// <summary>
    /// Web群发报警
    /// 该Job职责：从【OnCall->MessageBox】抓报警数据新增/分解到【OnCall->MessageQueue】消息队列表
    /// 1、关键字替换
    /// 
    /// AlarmType ：报警类型：1:机组报警，2:变位报警，3:人工Web群发消息报警
    /// MessageType：消息类型WeChat/SMS/Web
    /// </summary>
    public class AlarmWebJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
