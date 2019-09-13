using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.Systems.impl
{
    using System.Threading.Tasks;
    using OnCall.Web.Domain.Entity;
    using OnCall.Web.Domain.Infrastructure.DP;

    public class SysRoleAlarmLevelRepository : ISysRoleAlarmLevelRepository
    {
        private readonly DapperDBContext _context;
        public SysRoleAlarmLevelRepository(DapperDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<string>> GetAlarmLevel()
        {
            string sql = "select AlarmLevel from Sys_AlarmLevel";
            return await _context.QueryAsync<string>(sql);
        }

        public async Task<IEnumerable<ESysRoleAlarmLevel>> GetAllAsync()
        {
            return await _context.QueryAsync<ESysRoleAlarmLevel>("select RoleID,AlarmLevel from Sys_RoleAlarmLevel");
        }
        public async Task<IEnumerable<ESysRoleAlarmLevel>> GetAlarmLevelByRoleID(int RoleID)
        {
            string sql = "select RoleID,AlarmLevel from Sys_RoleAlarmLevel where RoleID=@RoleID";
            return await _context.QueryAsync<ESysRoleAlarmLevel>(sql,new { RoleID = RoleID });
        }
        //public async Task<IEnumerable<ESysRoleAlarmLevel>> GetDataAsync(string sWhere, Dapper.DynamicParameters param)
        //{
        //    string sql = "select RoleID,AlarmLevel from Sys_RoleAlarmLevel where RoleID=@RoleID";
        //    sql = string.Format(sql, sWhere);

        //    return await _context.QueryAsync<ESysRoleAlarmLevel>(sql, param);
        //}
        public async Task<bool> AddAsync(ESysRoleAlarmLevel eSysRoleAlarmLevel)
        {
            string sql = "insert into Sys_RoleAlarmLevel(RoleID,AlarmLevel) values(@RoleID,@AlarmLevel);select @@Identity;";
            return await _context.ExecuteAsync(sql, eSysRoleAlarmLevel) > 0;
        }


        public async Task<bool> DeleteAsync(int RoleID)
        {
            string sql = "delete from Sys_RoleAlarmLevel where RoleID=@RoleID";
            return await _context.ExecuteAsync(sql, new { RoleID = RoleID }) > 0;
        }

        
    }

}
