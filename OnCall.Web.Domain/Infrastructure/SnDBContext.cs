using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace OnCall.Web.Domain.Infrastructure.DP
{
    public class SnDBContext : DapperDBContext
    {
        public SnDBContext(IOptions<DapperDBContextOptions> optionsAccessor) : base(optionsAccessor)
        {
        }

        protected override IDbConnection CreateConnection(string connectionString)
        {
            IDbConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
