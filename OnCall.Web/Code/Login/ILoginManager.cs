using OnCall.Web.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnCall.Web.Code.Login
{
    public interface ILoginManager
    {
        bool IsAuthenticated();
        string LoginAccountName();
        ESysUserInfo LoginAccount();
        //string LoginUserMenu();
        IEnumerable<VMenu> GetLoginUserMenu();
        string NowDateTime();
    }
}
