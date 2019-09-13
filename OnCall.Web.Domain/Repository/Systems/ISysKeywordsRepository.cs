using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.Systems
{
    using OnCall.Web.Domain.Entity;
    using System.Threading.Tasks;
    public interface ISysKeywordsRepository
    {
        Task<bool> AddAsync(ESysKeywords eSysKeywords);
        Task<IEnumerable<ESysKeywords>> GetAllAsync();
        Task<IEnumerable<ESysKeywords>> GetPageAsync(int PageIndex, int PageSize, string sWhere, Dapper.DynamicParameters param);
        Task<int> GetTotalCount(string sWhere, Dapper.DynamicParameters param);
        Task<ESysKeywords> GetByIDAsync(int ID);
        Task<bool> DeleteAsync(int ID);
        Task<bool> DeletesAsync(string IDs);
        Task<bool> UpdateAsync(ESysKeywords eSysKeywords);
    }

}
