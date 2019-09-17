using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.Systems.impl
{
    using System.Threading.Tasks;
    using OnCall.Web.Domain.Entity;
    using OnCall.Web.Domain.Infrastructure.DP;

    public class SysRoleMenuRepository : ISysRoleMenuRepository
    {
        private readonly DapperDBContext _context;
        public SysRoleMenuRepository(DapperDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ESysRoleMenu>> GetMenuByRoleAsync(string sWhere, Dapper.DynamicParameters param)
        {
            string sql = "select RoleID,MenuID from Sys_RoleMenu where 1=1 {0}";
            sql = string.Format(sql, sWhere);
            return await _context.QueryAsync<ESysRoleMenu>(sql, param);
        }

        public async Task<bool> AddAsync(ESysRoleMenu eSysRoleMenu)
        {
            string sql = "insert into Sys_RoleMenu(RoleID,MenuID) values(@RoleID,@MenuID);select @@Identity;";
            return await _context.ExecuteAsync(sql, eSysRoleMenu) > 0;
        }

        public async Task<bool> DeleteAsync(int RoleID)
        {
            string sql = "delete from Sys_RoleMenu where RoleID=@RoleID";
            return await _context.ExecuteAsync(sql, new { RoleID = RoleID }) > 0;
        }


    }

}
