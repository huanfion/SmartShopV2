using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace SmartShop
{
    [DependsOn(typeof(AbpWebApiModule), typeof(SmartShopApplicationModule))]
    public class SmartShopWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(SmartShopApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
