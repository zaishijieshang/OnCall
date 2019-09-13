using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnCall.Web.Domain.Infrastructure.DP
{
    public class DapperDBContextOptions : IOptions<DapperDBContextOptions>
    {
        public string Configuration { get; set; }

        DapperDBContextOptions IOptions<DapperDBContextOptions>.Value
        {
            get { return this; }
        }
    }
}
