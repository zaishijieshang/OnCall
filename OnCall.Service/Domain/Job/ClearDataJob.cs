using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Job
{
    /*
     * 该Job职责：清理已完成/异常 数据从【OnCall->MessageQueue->MessageSuccess/MessageFault】移动到 MessageSuccess
     * 
     * 清理发送成功，及发送失败5次的数据
     */
    public class ClearDataJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
