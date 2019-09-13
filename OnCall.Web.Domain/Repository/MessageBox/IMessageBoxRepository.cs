using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.MessageBox
{
    using System.Threading.Tasks;
    using OnCall.Web.Domain.Entity;

    public interface IMessageBoxRepository
    {
        Task<bool> AddAsync(EMessageBox eMessageBox);
        Task<IEnumerable<EMessageBox>> GetAllAsync();
        Task<IEnumerable<EMessageBox>> GetPageAsync(int PageIndex, int PageSize, string sWhere, Dapper.DynamicParameters param);
        Task<int> GetTotalCount(string sWhere, Dapper.DynamicParameters param);
        Task<EMessageBox> GetByIDAsync(int ID);
        Task<bool> DeleteAsync(int ID);
        Task<bool> DeletesAsync(string IDs);
        Task<bool> UpdateAsync(EMessageBox eMessageBox);
    }

}
