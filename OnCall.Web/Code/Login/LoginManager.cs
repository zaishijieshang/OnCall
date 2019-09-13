using OnCall.Web.Domain.Infrastructure.DP.Entity;
using OnCall.Web.Code.Extensions;
using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;
namespace OnCall.Web.Code.Login
{
    public class LoginManager : ILoginManager
    {
        public static readonly string Issuer = "LoginUserKey";
        private ESysUserInfo _LoginAccount;

        private readonly IHttpContextAccessor _HttpContextAccessor;
        public LoginManager(IHttpContextAccessor httpContextAccessor)
        {
            _HttpContextAccessor = httpContextAccessor;
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
