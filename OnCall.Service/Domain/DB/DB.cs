using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OnCall.Service.Domain
{
    public class DB
    {
        public static IDbConnection DBConnection
        {
            get
            {
                var connHRString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                var conn = new SqlConnection(connHRString);
                conn.Open();
                return conn;
            }
        }
        public static IDbConnection AlarmDBConnection
        {
            get
            {
                var connHRString = ConfigurationManager.ConnectionStrings["AlarmDBConnection"].ConnectionString;
                var conn = new SqlConnection(connHRString);
                conn.Open();
                return conn;
            }
        }

    }
}
