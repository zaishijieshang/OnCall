using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.Systems.impl
{
    using System.Threading.Tasks;
    using OnCall.Web.Domain.Entity;
    using OnCall.Web.Domain.Infrastructure.DP;
    public class SysUserRoleRepository : ISysUserRoleRepository
    {
        private readonly DapperDBContext _context;
        public SysUserRoleRepository(DapperDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ESysUserRole>> GetAllAsync()
        {
            return await _context.QueryAsync<ESysUserRole>("select ID,RoleID,UserID,UserName from Sys_UserRole");
        }

        public async Task<IEnumerable<ESysUserRole>> GetPageAsync(int PageIndex, int PageSize, string sWhere, Dapper.DynamicParameters param)
        {
            string sql = "select * from(select ROW_NUMBER() over(order by ID desc)n,ID,RoleID,UserID,UserName from Sys_UserRole where 1=1 {0} ) p where p.n>@p1 and p.n<=@p2";
            sql = string.Format(sql, sWhere);
            param.Add("p1", (PageIndex - 1) * PageSize);
            param.Add("p2", PageIndex * PageSize);
            return await _context.QueryAsync<ESysUserRole>(sql, param);
        }

        public async Task<int> GetTotalCount(string sWhere, Dapper.DynamicParameters param)
        {
            string sql = string.Format("select count(1) from Sys_UserRole where 1=1 {0}", sWhere);
            return await _context.QueryFirstOrDefaultAsync<int>(sql, param);
        }

        public async Task<ESysUserRole> GetByIDAsync(int ID)
        {
            string sql = "select RoleID,UserID,UserName from Sys_UserRole where ID=@ID";
            return await _context.QueryFirstOrDefaultAsync<ESysUserRole>(sql, new { ID = ID });
        }

        public async Task<bool> AddAsync(ESysUserRole eSysUserRole)
        {
            string sql = "insert into Sys_UserRole(RoleID,UserID,UserName) values(@RoleID,@UserID,@UserName);select @@Identity;";
            return await _context.ExecuteAsync(sql, eSysUserRole) > 0;
        }

        public async Task<bool> UpdateAsync(ESysUserRole eSysUserRole)
        {
            string sql = "update Sys_UserRole set RoleID=@RoleID,UserID=@UserID,UserName=@UserName where ID=@ID;";
            return await _context.ExecuteAsync(sql, eSysUserRole) > 0;
        }

        public async Task<bool> DeleteAsync(int ID)
        {
            string sql = "delete from Sys_UserRole where ID=@ID";
            return await _context.ExecuteAsync(sql, new { ID = ID }) > 0;
        }

        public async Task<bool> DeletesAsync(string IDs)
        {
            string sql = "delete from Sys_UserRole where ID in @IDs";
            return await _context.ExecuteAsync(sql, new { IDs = IDs.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries) }) > 0;
        }
    }




}
