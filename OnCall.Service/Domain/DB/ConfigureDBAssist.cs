using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
namespace OnCall.Service.Domain
{
    public class ConfigureDBAssist
    {

        private static ConfigureDBAssist _ConfigureDBAssist;

        public static ConfigureDBAssist Instance
        {
            get
            {
                if (_ConfigureDBAssist == null)
                {
                    _ConfigureDBAssist = new ConfigureDBAssist();
                }
                return _ConfigureDBAssist;
            }
        }


        /// <summary>
        ///短信区域ID , 默认: default
        /// </summary>
        public string SMSRegionId
        {
            get
            {
                using (var db = DB.DBConnection)
                {
                    string sql = "select top 1 SMSRegionId from Sys_Configure where ID=1";
                    return db.Query<string>(sql).FirstOrDefault();
                }
            }
        }
        public string SMSAccessKeyId
        {
            get
            {
                using (var db = DB.DBConnection)
                {
                    string sql = "select top 1 SMSAccessKeyId from Sys_Configure where ID=1";
                    return db.Query<string>(sql).FirstOrDefault();
                }
            }
        }
        public string SMSAccessSecret
        {
            get
            {
                using (var db = DB.DBConnection)
                {
                    string sql = "select top 1 SMSAccessSecret from Sys_Configure where ID=1";
                    return db.Query<string>(sql).FirstOrDefault();
                }
            }
        }

        public string SMSSignName
        {
            get
            {
                using (var db = DB.DBConnection)
                {
                    string sql = "select top 1 SMSSignName from Sys_Configure where ID=1";
                    return db.Query<string>(sql).FirstOrDefault();
                }
            }
        }

        public string SMSTemplateCode
        {
            get
            {
                using (var db = DB.DBConnection)
                {
                    string sql = "select top 1 SMSTemplateCode from Sys_Configure where ID=1";
                    return db.Query<string>(sql).FirstOrDefault();
                }
            }
        }


        public string SMSDomain
        {
            get
            {
                using (var db = DB.DBConnection)
                {
                    string sql = "select top 1 SMSDomain from Sys_Configure where ID=1";
                    return db.Query<string>(sql).FirstOrDefault();
                }
            }
        }

        public string SMSVersion
        {
            get
            {
                using (var db = DB.DBConnection)
                {
                    string sql = "select top 1 SMSVersion from Sys_Configure where ID=1";
                    return db.Query<string>(sql).FirstOrDefault();
                }
            }
        }

        public string SMSAction
        {
            get
            {
                using (var db = DB.DBConnection)
                {
                    string sql = "select top 1 SMSAction from Sys_Configure where ID=1";
                    return db.Query<string>(sql).FirstOrDefault();
                }
            }
        }

    }
}
