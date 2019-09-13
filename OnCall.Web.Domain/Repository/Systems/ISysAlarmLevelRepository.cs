using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.Systems
{
    using System.Threading.Tasks;
    using OnCall.Web.Domain.Entity;

    public interface ISysAlarmLevelRepository
    {
        Task<bool> AddAsync(ESysAlarmLevel eSysAlarmLevel);
        Task<IEnumerable<ESysAlarmLevel>> GetAllAsync();
        Task<IEnumerable<ESysAlarmLevel>> GetPageAsync(int PageIndex, int PageSize, string sWhere, Dapper.DynamicParameters param);
        Task<int> GetTotalCount(string sWhere, Dapper.DynamicParameters param);
        Task<ESysAlarmLevel> GetByIDAsync(int ID);
        Task<bool> DeleteAsync(int ID);
        Task<bool> DeletesAsync(string IDs);
        Task<bool> UpdateAsync(ESysAlarmLevel eSysAlarmLevel);
    }

}
