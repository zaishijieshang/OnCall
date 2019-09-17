using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.Systems
{
    using OnCall.Web.Domain.Entity;
    using System.Threading.Tasks;
    public interface ISysRoleMenuRepository
    {

        Task<bool> AddAsync(ESysRoleMenu eSysRoleMenu);

        Task<IEnumerable<ESysRoleMenu>> GetMenuByRoleAsync(string sWhere, Dapper.DynamicParameters param);

        Task<bool> DeleteAsync(int RoleID);


    }

}
