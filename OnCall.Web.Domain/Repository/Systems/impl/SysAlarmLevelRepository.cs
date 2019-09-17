using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.Systems.impl
{
    using OnCall.Web.Domain.Entity;
    using OnCall.Web.Domain.Infrastructure.DP;
    using System.Threading.Tasks;
    public class SysAlarmLevelRepository : ISysAlarmLevelRepository
    {
        private readonly DapperDBContext _context;
        public SysAlarmLevelRepository(DapperDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ESysAlarmLevel>> GetAlarmLevel(int AlarmLevelType)
        {
            string sql = "select ID,AlarmLevel,AlarmType,iAlarmLevel from Sys_AlarmLevel where AlarmType=@AlarmType";
            return await _context.QueryAsync<ESysAlarmLevel>(sql, new { AlarmType = AlarmLevelType });
        }
        public async Task<IEnumerable<ESysAlarmLevel>> GetAllAsync()
        {
            return await _context.QueryAsync<ESysAlarmLevel>("select ID,AlarmLevel,AlarmType,iAlarmLevel from Sys_AlarmLevel");
        }

        public async Task<IEnumerable<ESysAlarmLevel>> GetPageAsync(int PageIndex, int PageSize, string sWhere, Dapper.DynamicParameters param)
        {
            string sql = "select * from(select ROW_NUMBER() over(order by ID desc)n,ID,AlarmLevel,AlarmType,iAlarmLevel from Sys_AlarmLevel where 1=1 {0} ) p where p.n>@p1 and p.n<=@p2";
            sql = string.Format(sql, sWhere);
            param.Add("p1", (PageIndex - 1) * PageSize);
            param.Add("p2", PageIndex * PageSize);
            return await _context.QueryAsync<ESysAlarmLevel>(sql, param);
        }

        public async Task<int> GetTotalCount(string sWhere, Dapper.DynamicParameters param)
        {
            string sql = string.Format("select count(1) from Sys_AlarmLevel where 1=1 {0}", sWhere);
            return await _context.QueryFirstOrDefaultAsync<int>(sql, param);
        }

        public async Task<ESysAlarmLevel> GetByIDAsync(int ID)
        {
            string sql = "select AlarmLevel,AlarmType,iAlarmLevel from Sys_AlarmLevel where ID=@ID";
            return await _context.QueryFirstOrDefaultAsync<ESysAlarmLevel>(sql, new { ID = ID });
        }

        public async Task<bool> AddAsync(ESysAlarmLevel eSysAlarmLevel)
        {
            string sql = "insert into Sys_AlarmLevel(AlarmLevel,AlarmType,iAlarmLevel) values(@AlarmLevel,@AlarmType,@iAlarmLevel);select @@Identity;";
            return await _context.ExecuteAsync(sql, eSysAlarmLevel) > 0;
        }

        public async Task<bool> UpdateAsync(ESysAlarmLevel eSysAlarmLevel)
        {
            string sql = "update Sys_AlarmLevel set AlarmLevel=@AlarmLevel,AlarmType=@AlarmType,iAlarmLevel=@iAlarmLevel where ID=@ID;";
            return await _context.ExecuteAsync(sql, eSysAlarmLevel) > 0;
        }

        public async Task<bool> DeleteAsync(int ID)
        {
            string sql = "delete from Sys_AlarmLevel where ID=@ID";
            return await _context.ExecuteAsync(sql, new { ID = ID }) > 0;
        }

        public async Task<bool> DeletesAsync(string IDs)
        {
            string sql = "delete from Sys_AlarmLevel where ID in @IDs";
            return await _context.ExecuteAsync(sql, new { IDs = IDs.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries) }) > 0;
        }
    }
}

