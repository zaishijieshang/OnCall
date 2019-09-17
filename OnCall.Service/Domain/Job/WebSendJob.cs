using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Job
{
    /*
      * 该Job职责：从【OnCall->MessageQueue】抓取短信类消息，并进行看板数据推送
      * 
      * 1、【发送成功】将设置状态为成功，并从MessageQueue 移动到 MessageSuccess
      * 2、【发送失败】将状态设为为失败，并累计FaultCount错误数
      * 3、发起者回送确认信息
      * 
      */
    public class WebSendJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
