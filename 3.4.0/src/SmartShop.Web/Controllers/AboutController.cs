using System.Web.Mvc;

namespace SmartShop.Web.Controllers
{
    public class AboutController : SmartShopControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}