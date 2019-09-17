using OnCall.Web.Domain.Entity;
using OnCall.Web.Code.Extensions;
using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using OnCall.Web.Domain.Repository.Systems;
using System.Collections.Generic;

namespace OnCall.Web.Code.Login
{
    public class LoginManager : ILoginManager
    {
        public static readonly string Issuer = "LoginUserKey";
        private ESysUserInfo _LoginAccount;

        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly ISysUserInfoRepository _SysUserInfoRepository;
        public LoginManager(IHttpContextAccessor httpContextAccessor, ISysUserInfoRepository SysUserInfoRepository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _SysUserInfoRepository = SysUserInfoRepository;
        }

        public IEnumerable<VMenu> GetLoginUserMenu()
        {
            IEnumerable<VMenu> listMenu =  _SysUserInfoRepository.GetUserMenu(LoginAccount().UserID);
            return listMenu;
        }

        public bool IsAuthenticated()
        {
            ClaimsIdentity claimsIdentity = _HttpContextAccessor.HttpContext.User.Identity as ClaimsIdentity;
            return claimsIdentity.IsAuthenticated;
        }

        public string LoginAccountName()
        {
            ClaimsIdentity claimsIdentity = _HttpContextAccessor.HttpContext.User.Identity as ClaimsIdentity;
            if (claimsIdentity.HasClaim(c => c.Type == ClaimTypes.Name))
            {
                return claimsIdentity.FindFirst(ClaimTypes.Name).Value;
            }
            else
            {
                return claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            }
        }

        //public string LoginUserMenu()
        //{
        //    string loginMenu = string.Empty;
        //    ClaimsIdentity claimsIdentity = _HttpContextAccessor.HttpContext.User.Identity as ClaimsIdentity;
        //    if (claimsIdentity.HasClaim(c => c.Type == ClaimTypes.AuthorizationDecision))
        //    {
        //        loginMenu = claimsIdentity.FindFirst(ClaimTypes.AuthorizationDecision).Value;
        //    }
        //    return loginMenu;
        //}

        public ESysUserInfo LoginAccount()
        {
            ClaimsIdentity claimsIdentity = _HttpContextAccessor.HttpContext.User.Identity as ClaimsIdentity;

            if (_LoginAccount == null)
            {
                _LoginAccount = claimsIdentity.FindFirst(ClaimTypes.UserData).Value.ToObject<ESysUserInfo>();
            }

            return _LoginAccount;
        }

        public string NowDateTime()
        {
            return DateTime.Now.ToDateTime();
        }

    }


}
