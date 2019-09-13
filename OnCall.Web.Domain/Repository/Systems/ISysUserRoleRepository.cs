using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.Systems
{
    using OnCall.Web.Domain.Entity;
    using System.Threading.Tasks;
    public interface ISysUserRoleRepository
    {
        Task<bool> AddAsync(ESysUserRole eSysUserRole);
        Task<IEnumerable<ESysUserRole>> GetAllAsync();
        Task<IEnumerable<ESysUserRole>> GetPageAsync(int PageIndex, int PageSize, string sWhere, Dapper.DynamicParameters param);
        Task<int> GetTotalCount(string sWhere, Dapper.DynamicParameters param);
        Task<ESysUserRole> GetByIDAsync(int ID);
        Task<bool> DeleteAsync(int ID);
        Task<bool> DeletesAsync(string IDs);
        Task<bool> UpdateAsync(ESysUserRole eSysUserRole);
    }


}
