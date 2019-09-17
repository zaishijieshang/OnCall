using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Job
{
    /*
      * 该Job职责：数据库备份
      * 1、完整数据库备份
      * 2、差异数据库备份
      * 3、部分备份
      * 4、事务日志备份
      * 5、尾日志备份
      * 6、文件和文件组备份
      */
    public class DBBackJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
