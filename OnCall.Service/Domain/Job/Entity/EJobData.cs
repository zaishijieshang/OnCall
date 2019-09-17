using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnCall.Service.Domain.Job.Entity
{
    public class EJobData
    {
        public DateTime ExeTime { get; set; }
        public string JobTitle { get; set; }
        public string ExeResult { get; set; }
        /// <summary>
        ///状态   0:ok/success，1:fault/error,  2:exception
        /// </summary>
        public int Status { get; set; }
    }
}
