using SmartShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SmartShop.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class MemberAuthorizeAttribute : FilterAttribute, IAuthorizationFilter
    {
        private bool requireSystemAdministrator = true;
        /// <summary>
        /// 是否需要系统管理员权限
        /// </summary>
        public bool RequireSystemAdministrator
        {
            get { return requireSystemAdministrator; }
            set { requireSystemAdministrator = value; }
        }
        #region IAuthorizationFilter 成员
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }
            if (!AuthorizeCore(filterContext))
            {
                if (filterContext.RequestContext.HttpContext.Request.IsAjaxRequest())
                {
                    filterContext.Result = new JsonResult
                    {
                        Data = new
                        {
                            result = -1,
                            msg = "请选择登录."
                        }
                    };
                }
                else
                {
                    filterContext.Controller.TempData["StatusMessageData"] = new
                    {
                        result = -1,
                        msg = "请选择登录."
                    };

                    filterContext.Result = new RedirectResult("/User/Login");
                }
            }
        }
        #endregion
        private bool AuthorizeCore(AuthorizationContext filterContext)
        {
            if (requireSystemAdministrator == false)
            {
                return true;
            }

            string _adminIdStr =CookieHelper.GetCookie("_memid");
            string _adminNameStr = CookieHelper.GetCookie("_memname");
            string _adminPhoneStr = CookieHelper.GetCookie("_memphone");

            if (string.IsNullOrEmpty(_adminIdStr) || string.IsNullOrEmpty(_adminPhoneStr))
            {
                return false;
            }
            int.TryParse(Common.Encrypt.Decode(_adminIdStr, "smartshop"), out int adminid);
            if (adminid > 0)
            {
                filterContext.Controller.ViewBag.MemberId = adminid;
                filterContext.Controller.ViewBag.MemberPhone = Common.Encrypt.Decode(_adminPhoneStr,"smartshop");
                filterContext.Controller.ViewBag.MemberName = Common.Encrypt.Decode(_adminNameStr, "smartshop");
                return true;
            }
            return false;
        }

    }
}
