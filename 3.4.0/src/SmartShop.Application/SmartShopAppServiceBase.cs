using Abp.Application.Services;

namespace SmartShop
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class SmartShopAppServiceBase : ApplicationService
    {
        protected SmartShopAppServiceBase()
        {
            LocalizationSourceName = SmartShopConsts.LocalizationSourceName;
        }
    }
}