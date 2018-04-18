using System.Web.Mvc;

namespace SmartShop.Web.Controllers
{
    public class HomeController : SmartShopControllerBase
    {
        public ActionResult Index()
        {
            return Content("") ;
        }
	}
}