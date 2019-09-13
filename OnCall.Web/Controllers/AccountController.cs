using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using OnCall.Web.Domain.Infrastructure.DP.Entity;
using OnCall.Web.Code.Extensions;
using OnCall.Web.Code.Login;
using OnCall.Web.Code.Util;
using OnCall.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnCall.Web.Domain.Repository.Systems;

namespace OnCall.Web.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private ISysUserInfoRepository _SysUserInfoRepository;


        public AccountController(ISysUserInfoRepository SysUserInfoRepository)
        {
            _SysUserInfoRepository = SysUserInfoRepository;
        }
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signin(string username, string password, string remember)
        {
            EResult re = new EResult() { StatusCode = -1, Status = false, Message = "fault" };
            try
            {
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    string pwd5 = MD5Util.Get32MD5Two(password);
                    (bool, ESysUserInfo) reLogin = _SysUserInfoRepository.Login(username, pwd5);
                    if (reLogin.Item1)
                    {
                        if (reLogin.Item2.Status == 1)
                        {
                            ESysUserInfo _user = reLogin.Item2;

                            IList<Claim> claims = new List<Claim>();

                            claims.Add(new Claim(ClaimTypes.Name, _user.UserName, ClaimValueTypes.String, LoginManager.Issuer));
                            claims.Add(new Claim(ClaimTypes.NameIdentifier, _user.UserID.ToString(), ClaimValueTypes.String, LoginManager.Issuer));
                            //获取权限
                            claims.Add(new Claim(ClaimTypes.Role, "Administrator", ClaimValueTypes.String, LoginManager.Issuer));
                            claims.Add(new Claim(ClaimTypes.UserData, _user.ToJson(), ClaimValueTypes.String, LoginManager.Issuer));

                            //身份可以有多个身份 如：驾照/身份证/户口本
                            var userIdentity = new ClaimsIdentity(LoginManager.Issuer);
                            userIdentity.AddClaims(claims);

                            //主体,只有1个
                            var userPrincipal = new ClaimsPrincipal(userIdentity);

                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal,
                                    new AuthenticationProperties
                                    {
                                        ExpiresUtc = DateTime.UtcNow.AddMinutes(remember == "on" ? (1440 * 30) : 1440),
                                        IsPersistent = false,
                                        AllowRefresh = false
                                    });

                       
                            re.Status = true;
                            re.StatusCode = 0;
                            re.Message = "登陆成功.";
                        }
                        else
                        {
                            re.Message = "该账户已禁用.";
                        }
                    }
                    else
                    {
                        re.Message = "用户名或密码错误.";
                    }
                }
                else
                {
                    re.Message = "用户名或密码不能为空";
                }

            }
            catch (Exception ex)
            {
                re.Message = ex.Message;
            }
            return Ok(re);
            //return RedirectToLocal("/");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok(new { code = 0, msg = "退出成功" });
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
