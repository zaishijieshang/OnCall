using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnCall.Service.Domain.Job
{
    public class BuilderJob
    {
        public static IJob CreateJob(string JobName)
        {
            Type type = Type.GetType(JobName);

            IJob _IJob= null;
            if (type != null)
            {
                _IJob = Activator.CreateInstance(type) as IJob;
            }
            else
            {
                Assembly assembly = Assembly.Load("OnCall.Service");//typeof(Program).Assembly;
                string typeName = string.Format("OnCall.Service.Domain.Job.{0}", JobName);
                _IJob = assembly.CreateInstance(typeName) as IJob;
            }

            return _IJob;
        }
    }
}
