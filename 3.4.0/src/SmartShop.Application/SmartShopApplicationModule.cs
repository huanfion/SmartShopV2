using System.Reflection;
using Abp.Modules;

namespace SmartShop
{
    [DependsOn(typeof(SmartShopCoreModule))]
    public class SmartShopApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
