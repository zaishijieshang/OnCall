using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.Systems.impl
{
    using System.Threading.Tasks;
    using OnCall.Web.Domain.Infrastructure.DP;
    using OnCall.Web.Domain.Entity;

    public class SysKeywordsRepository : ISysKeywordsRepository
    {
        private readonly DapperDBContext _context;
        public SysKeywordsRepository(DapperDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ESysKeywords>> GetAllAsync()
        {
            return await _context.QueryAsync<ESysKeywords>("select ID,Keyword,ReplaceValue,Status from Sys_Keywords");
        }

        public async Task<IEnumerable<ESysKeywords>> GetPageAsync(int PageIndex, int PageSize, string sWhere, Dapper.DynamicParameters param)
        {
            string sql = "select * from(select ROW_NUMBER() over(order by ID desc)n,ID,Keyword,ReplaceValue,Status from Sys_Keywords where 1=1 {0} ) p where p.n>@p1 and p.n<=@p2";
            sql = string.Format(sql, sWhere);
            param.Add("p1", (PageIndex - 1) * PageSize);
            param.Add("p2", PageIndex * PageSize);
            return await _context.QueryAsync<ESysKeywords>(sql, param);
        }

        public async Task<int> GetTotalCount(string sWhere, Dapper.DynamicParameters param)
        {
            string sql = string.Format("select count(1) from Sys_Keywords where 1=1 {0}", sWhere);
            return await _context.QueryFirstOrDefaultAsync<int>(sql, param);
        }

        public async Task<ESysKeywords> GetByIDAsync(int ID)
        {
            string sql = "select Keyword,ReplaceValue,Status from Sys_Keywords where ID=@ID";
            return await _context.QueryFirstOrDefaultAsync<ESysKeywords>(sql, new { ID = ID });
        }

        public async Task<bool> AddAsync(ESysKeywords eSysKeywords)
        {
            string sql = "insert into Sys_Keywords(Keyword,ReplaceValue,Status) values(@Keyword,@ReplaceValue,@Status);select @@Identity;";
            return await _context.ExecuteAsync(sql, eSysKeywords) > 0;
        }

        public async Task<bool> UpdateAsync(ESysKeywords eSysKeywords)
        {
            string sql = "update Sys_Keywords set Keyword=@Keyword,ReplaceValue=@ReplaceValue,Status=@Status where ID=@ID;";
            return await _context.ExecuteAsync(sql, eSysKeywords) > 0;
        }

        public async Task<bool> DeleteAsync(int ID)
        {
            string sql = "delete from Sys_Keywords where ID=@ID";
            return await _context.ExecuteAsync(sql, new { ID = ID }) > 0;
        }

        public async Task<bool> DeletesAsync(string IDs)
        {
            string sql = "delete from Sys_Keywords where ID in @IDs";
            return await _context.ExecuteAsync(sql, new { IDs = IDs.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries) }) > 0;
        }
    }

}
