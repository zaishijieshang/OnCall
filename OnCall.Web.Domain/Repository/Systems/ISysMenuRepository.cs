using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.Systems
{
    using OnCall.Web.Domain.Entity;
    using System.Threading.Tasks;
    public interface ISysMenuRepository
    {
        Task<IEnumerable<ESysMenu>> GetMenuByParentIDAsync(int ParentID);
        Task<bool> AddAsync(ESysMenu eSysMenu);
        Task<IEnumerable<ESysMenu>> GetAllAsync();
        Task<IEnumerable<ESysMenu>> GetPageAsync(int PageIndex, int PageSize, string sWhere, Dapper.DynamicParameters param);
        Task<int> GetTotalCount(string sWhere, Dapper.DynamicParameters param);
        Task<ESysMenu> GetByIDAsync(int ID);
        Task<bool> DeleteAsync(int ID);
        Task<bool> DeletesAsync(string IDs);
        Task<bool> UpdateAsync(ESysMenu eSysMenu);
    }

}
