using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.Systems
{
    using OnCall.Web.Domain.Entity;
    using System.Threading.Tasks;
    public interface ISysRoleRepository
    {
        Task<bool> AddAsync(ESysRole eSysRole);
        Task<IEnumerable<ESysRole>> GetAllAsync();
        Task<IEnumerable<ESysRole>> GetPageAsync(int PageIndex, int PageSize, string sWhere, Dapper.DynamicParameters param);
        Task<int> GetTotalCount(string sWhere, Dapper.DynamicParameters param);
        Task<ESysRole> GetByIDAsync(int ID);
        Task<bool> DeleteAsync(int ID);
        Task<bool> DeletesAsync(string IDs);
        Task<bool> UpdateAsync(ESysRole eSysRole);
    }

}
