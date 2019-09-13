using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnCall.Web.Code.Extensions
{
    public static class GeneralExtensions
    {
        public static string ToDateTime(this DateTime time)
        {
            if (time != null)
            {
                return time.ToString("yyyy-MM-dd HH:mm:ss");
            }
            return string.Empty;
        }
    }
}
