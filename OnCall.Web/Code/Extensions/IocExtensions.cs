using OnCall.Web.Code.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using OnCall.Web.Domain.Repository.Systems.impl;
using OnCall.Web.Domain.Repository.Systems;
using OnCall.Web.Domain.Repository.MessageBox;
using OnCall.Web.Domain.Repository.MessageBox.impl;

namespace OnCall.Web.Code.Extensions
{
    public static class IocExtensions
    {
        public static void IocService(this IServiceCollection services)
        {
            services.AddTransient<ILoginManager, LoginManager>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ISysUserInfoRepository, SysUserInfoRepository>();
            services.AddTransient<ISysKeywordsRepository, SysKeywordsRepository>();
            services.AddTransient<ISysRoleRepository, SysRoleRepository>();
            services.AddTransient<IMessageBoxRepository, MessageBoxRepository>();
            services.AddTransient<ISysMenuRepository, SysMenuRepository>();
            services.AddTransient<ISysAlarmLevelRepository, SysAlarmLevelRepository>();
            services.AddTransient<ISysUserRoleRepository, SysUserRoleRepository>();
            services.AddTransient<ISysRoleAlarmLevelRepository, SysRoleAlarmLevelRepository>();
        }

    }
}
