using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.Systems.impl
{
    using OnCall.Web.Domain.Entity;
    using OnCall.Web.Domain.Infrastructure.DP;
    using System.Threading.Tasks;
    public class SysMenuRepository : ISysMenuRepository
    {
        private readonly DapperDBContext _context;
        public SysMenuRepository(DapperDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ESysMenu>> GetAllAsync()
        {
            return await _context.QueryAsync<ESysMenu>("select MenuID,MenuTitle,MenuUrl,ParentID,Sort,Status from Sys_Menu");
        }

        public async Task<IEnumerable<ESysMenu>> GetPageAsync(int PageIndex, int PageSize, string sWhere, Dapper.DynamicParameters param)
        {
            string sql = "select * from(select ROW_NUMBER() over(order by MenuID desc)n,MenuID,MenuTitle,MenuUrl,ParentID,Sort,Status from Sys_Menu where 1=1 {0} ) p where p.n>@p1 and p.n<=@p2";
            sql = string.Format(sql, sWhere);
            param.Add("p1", (PageIndex - 1) * PageSize);
            param.Add("p2", PageIndex * PageSize);
            return await _context.QueryAsync<ESysMenu>(sql, param);
        }

        public async Task<int> GetTotalCount(string sWhere, Dapper.DynamicParameters param)
        {
            string sql = string.Format("select count(1) from Sys_Menu where 1=1 {0}", sWhere);
            return await _context.QueryFirstOrDefaultAsync<int>(sql, param);
        }

        public async Task<ESysMenu> GetByIDAsync(int MenuID)
        {
            string sql = "select MenuTitle,MenuUrl,ParentID,Sort,Status from Sys_Menu where MenuID=@MenuID";
            return await _context.QueryFirstOrDefaultAsync<ESysMenu>(sql, new { MenuID = MenuID });
        }

        public async Task<bool> AddAsync(ESysMenu eSysMenu)
        {
            string sql = "insert into Sys_Menu(MenuTitle,MenuUrl,ParentID,Sort,Status) values(@MenuTitle,@MenuUrl,@ParentID,@Sort,@Status);select @@Identity;";
            return await _context.ExecuteAsync(sql, eSysMenu) > 0;
        }

        public async Task<bool> UpdateAsync(ESysMenu eSysMenu)
        {
            string sql = "update Sys_Menu set MenuTitle=@MenuTitle,MenuUrl=@MenuUrl,ParentID=@ParentID,Sort=@Sort,Status=@Status where MenuID=@MenuID;";
            return await _context.ExecuteAsync(sql, eSysMenu) > 0;
        }

        public async Task<bool> DeleteAsync(int MenuID)
        {
            string sql = "delete from Sys_Menu where MenuID=@MenuID";
            return await _context.ExecuteAsync(sql, new { MenuID = MenuID }) > 0;
        }

        public async Task<bool> DeletesAsync(string MenuIDs)
        {
            string sql = "delete from Sys_Menu where MenuID in @IDs";
            return await _context.ExecuteAsync(sql, new { IDs = MenuIDs.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries) }) > 0;
        }
    }

}
