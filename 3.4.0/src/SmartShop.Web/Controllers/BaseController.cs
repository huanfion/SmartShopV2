using SmartShop.Entities.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SmartShop.Web.Controllers
{
    public class BaseController : Controller
    {
        protected Assets assets { get; set; }



        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            string memberIdStr = Common.CookieHelper.GetCookie("_memid");
            string memberCartStr = Common.CookieHelper.GetCookie("_memcart");
            string memberPhoneStr = Common.CookieHelper.GetCookie("_memphone");

            assets = new Assets();
            if (string.IsNullOrEmpty(memberCartStr))
            {
                memberCartStr = Common.Encrypt.MD5(DateTime.Now.Ticks.ToString());
                Common.CookieHelper.SetCookie("_memcart", memberCartStr, 72);
            }
            assets.CookieTag = memberCartStr;

            int.TryParse(Common.Encrypt.Decode(memberIdStr, "smartshop"), out int adminid);
            if (adminid > 0)
            {
                assets.MemberId = adminid;
                if (!string.IsNullOrEmpty(memberPhoneStr))
                {
                    assets.MemberPhone = Common.Encrypt.Decode(memberPhoneStr, "smartshop");
                }
            }

        }
    }
}