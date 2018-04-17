using System.Reflection;
using Abp.Modules;

namespace SmartShop
{
    public class SmartShopCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
