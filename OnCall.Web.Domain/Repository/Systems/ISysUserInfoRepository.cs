using OnCall.Web.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnCall.Web.Domain.Repository.Systems
{
    public interface ISysUserInfoRepository
    {
        IEnumerable<VMenu> GetUserMenu(int UserID);
        Task<bool> AddAsync(ESysUserInfo prod);
        Task<IEnumerable<ESysUserInfo>> GetAllAsync();
        Task<IEnumerable<ESysUserInfo>> GetPageAsync(int PageIndex, int PageSize, string sWhere, Dapper.DynamicParameters param);
        Task<int> GetTotalCount(string sWhere, Dapper.DynamicParameters param);
        Task<ESysUserInfo> GetByIDAsync(int id);
        (bool, ESysUserInfo) Login(string UserName, string Pwd);
        Task<bool> DeleteAsync(int id);
        Task<bool> DeletesAsync(string IDs);
        Task<bool> UpdateAsync(ESysUserInfo prod);
    }

}
