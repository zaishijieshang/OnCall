using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.Systems
{
    using System.Threading.Tasks;
    using OnCall.Web.Domain.Entity;
    using OnCall.Web.Domain.Enum;

    public interface ISysRoleAlarmLevelRepository
    {
        Task<bool> AddAsync(ESysRoleAlarmLevel eSysRoleAlarmLevel);
        Task<IEnumerable<ESysRoleAlarmLevel>> GetAllAsync();
        Task<bool> DeleteAsync(int ID);

        Task<IEnumerable<ESysRoleAlarmLevel>> GetAlarmLevelByRoleID(int RoleID);
        Task<IEnumerable<ESysRoleAlarmLevel>> GetAlarmLevelByRoleID(int RoleID, enAlarmLevelType alarmType);

    }

}
