using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using SmartShop.EntityFramework;

namespace SmartShop
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(SmartShopCoreModule))]
    public class SmartShopDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<SmartShopDbContext>(null);
        }
    }
}
