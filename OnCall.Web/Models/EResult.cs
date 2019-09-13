using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnCall.Web.Models
{
    public class EResult
    {
        public int StatusCode { get; set; } = -1;
        public bool Status { get; set; } = false;
        public string Message { get; set; } = "fault";
        public object Data { get; set; } = null;
    }

    public class EResultObject<T>
    {
        public int StatusCode { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }

        public T Data { get; set; }
    }
}
