using Abp.Web.Mvc.Controllers;

namespace SmartShop.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class SmartShopControllerBase : AbpController
    {
        protected SmartShopControllerBase()
        {
            LocalizationSourceName = SmartShopConsts.LocalizationSourceName;
        }
    }
}