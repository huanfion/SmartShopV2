using SmartShop.Entities;
using SmartShop.Filters;
using SmartShop.Web.Models.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartShop.Web.Controllers
{
    public class UserController : Controller
    {
        
        /// <summary>
        /// 会员中心首页
        /// </summary>
        /// <returns></returns>
        // GET: User
        [MemberAuthorize]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 会员登录页
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            SigninEditModel model = new SigninEditModel();
            string callbackUrl = "/user/index";
            return View(model);
        }
        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <returns></returns>
        public JsonResult GetSigninCode(string phone)
        {
            //ResultMessage result = new ResultMessage();
            //bool results = Service.PhoneValid.SendValid(phone.Trim());
            return null;
        }

    }
}