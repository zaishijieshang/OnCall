using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.Systems.impl
{
    using OnCall.Web.Domain.Infrastructure.DP;
    using OnCall.Web.Domain.Entity;
    using System.Threading.Tasks;
    public class SysRoleRepository : ISysRoleRepository
    {
        private readonly DapperDBContext _context;
        public SysRoleRepository(DapperDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ESysRole>> GetAllAsync()
        {
            return await _context.QueryAsync<ESysRole>("select RoleID,RoleName,Status,Mark from Sys_Role");
        }

        public async Task<IEnumerable<ESysRole>> GetPageAsync(int PageIndex, int PageSize, string sWhere, Dapper.DynamicParameters param)
        {
            string sql = "select * from(select ROW_NUMBER() over(order by RoleID desc)n,RoleID,RoleName,Status,Mark from Sys_Role where 1=1 {0} ) p where p.n>@p1 and p.n<=@p2";
            sql = string.Format(sql, sWhere);
            param.Add("p1", (PageIndex - 1) * PageSize);
            param.Add("p2", PageIndex * PageSize);
            return await _context.QueryAsync<ESysRole>(sql, param);
        }

        public async Task<int> GetTotalCount(string sWhere, Dapper.DynamicParameters param)
        {
            string sql = string.Format("select count(1) from Sys_Role where 1=1 {0}", sWhere);
            return await _context.QueryFirstOrDefaultAsync<int>(sql, param);
        }

        public async Task<ESysRole> GetByIDAsync(int RoleID)
        {
            string sql = "select RoleName,Status,Mark from Sys_Role where RoleID=@RoleID";
            return await _context.QueryFirstOrDefaultAsync<ESysRole>(sql, new { RoleID = RoleID });
        }

        public async Task<bool> AddAsync(ESysRole eSysRole)
        {
            string sql = "insert into Sys_Role(RoleName,Status,Mark) values(@RoleName,@Status,@Mark);select @@Identity;";
            return await _context.ExecuteAsync(sql, eSysRole) > 0;
        }

        public async Task<bool> UpdateAsync(ESysRole eSysRole)
        {
            string sql = "update Sys_Role set RoleName=@RoleName,Status=@Status,Mark=@Mark where RoleID=@RoleID;";
            return await _context.ExecuteAsync(sql, eSysRole) > 0;
        }

        public async Task<bool> DeleteAsync(int RoleID)
        {
            string sql = "delete from Sys_Role where RoleID=@RoleID";
            return await _context.ExecuteAsync(sql, new { RoleID = RoleID }) > 0;
        }

        public async Task<bool> DeletesAsync(string RoleIDs)
        {
            string sql = "delete from Sys_Role where RoleID in @IDs";
            return await _context.ExecuteAsync(sql, new { IDs = RoleIDs.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries) }) > 0;
        }
    }

}
