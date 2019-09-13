using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnCall.Web.Domain.Infrastructure.DP
{
    public static class DapperDBContextServiceCollectionExtensions
    {
        public static IServiceCollection AddDapperDBContext<T>(this IServiceCollection services, Action<DapperDBContextOptions> setupAction) where T : DapperDBContext
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (setupAction == null)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }

            services.AddOptions();
            services.Configure(setupAction);
            services.AddScoped<DapperDBContext, T>();
            services.AddScoped<IUnitOfWorkFactory, DapperUnitOfWorkFactory>();

            //权重：
            //AddSingleton→AddTransient→AddScoped

            //AddSingleton的生命周期：（单例模式）
            //项目启动 - 项目关闭   相当于静态类 只会有一个

            //AddScoped的生命周期：【在同一次请求中，获取多次对象得到的是同一个对象】
            //请求开始 - 请求结束  在这次请求中获取的对象都是同一个

            //  AddTransient的生命周期：（瞬时模式）
            //请求获取 -（GC回收 - 主动释放） 每一次获取的对象都不是同一个

            //注意：
            //由于AddScoped对象是在请求的时候创建的
            //所以不能在AddSingleton对象中使用
            //甚至也不能在AddTransient对象中使用

            //所以权重为
            //AddSingleton→AddTransient→AddScoped
            return services;
        }
    }
}
