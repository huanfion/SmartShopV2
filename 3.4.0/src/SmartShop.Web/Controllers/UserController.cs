using SmartShop.Common;
using SmartShop.Common.PhoneValidApp;
using SmartShop.Core.Entities;
using SmartShop.Entities;
using SmartShop.Filters;
using SmartShop.PhoneValidApp;
using SmartShop.ShopCartApp;
using SmartShop.ShopOrderApp;
using SmartShop.UserApp;
using SmartShop.Web.Models.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartShop.Web.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IPhoneValidService _phoneValidService;
        private readonly IShopCartAppService _shopcartService;
        public UserController(IUserService userService,
            IPhoneValidService phoneValidService
            , IShopCartAppService shopcartService)
        {
            this._userService = userService;
            this._phoneValidService = phoneValidService;
            this._shopcartService = shopcartService;

        }
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
        /// 用户购物车页面
        /// </summary>
        /// <returns></returns>
        public ActionResult cart()
        {
            List<ShopCart> list = new List<ShopCart>();
            if (assets.MemberId > 0)
            {
                 list = _shopcartService.GetCartListByMemberId(assets.MemberId);
            }
            else
            {
                 list = _shopcartService.GetCartListByTag(assets.CookieTag);
            }
            
            return View(list);
        }
        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <returns></returns>
        public JsonResult GetSigninCode(string phone)
        {
            ResultMessage result = new ResultMessage();
            bool results = _phoneValidService.SendValid(phone.Trim());

            if (results)
            {
                result.Code = 1;
                result.Message = "验证码发送成功！";
            }
            else
            {
                result.Code = -1;
                result.Message = "验证码发送失败！";
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CheckIdentity(string Phone, string Code)
        {
            ResultMessage result = new ResultMessage();
            if (!_phoneValidService.ValidPhone(Phone, Code))
            {
                result.Code = -1;
                result.Message = "验证码错误";
            }

            else
            {
                var user = _userService.GetUserByPhone(Phone);
                if (user != null)
                {
                    #region 更新购物车
                    if (!string.IsNullOrEmpty(assets.CookieTag))
                    {
                        _shopcartService.BindCart(assets.CookieTag, user.Id);
                    }
                    //管理员id
                    CookieHelper.SetCookie("_memid", Encrypt.Encode(user.Id.ToString(), "SmartShop"));
                    CookieHelper.SetCookie("_memname", Encrypt.Encode(user.NickName.ToString(), "SmartShop"));
                    CookieHelper.SetCookie("_memphone", Encrypt.Encode(user.Mobile.ToString(), "SmartShop"));
                    #endregion
                    result.Code = 1;
                    result.Message = "登录成功";
                }
                else
                {
                    HTUser newuser = new HTUser();
                    newuser.Mobile = Phone;
                    newuser.Id=_userService.InsertUser(newuser);
                    if (newuser.Id > 0)
                    {
                        #region 更新购物车
                        if (!string.IsNullOrEmpty(assets.CookieTag))
                        {
                            _shopcartService.BindCart(assets.CookieTag, user.Id);
                        }
                        //管理员id
                        CookieHelper.SetCookie("_memid", Encrypt.Encode(user.Id.ToString(), "SmartShop"));
                        CookieHelper.SetCookie("_memname", Encrypt.Encode(user.NickName.ToString(), "SmartShop"));
                        CookieHelper.SetCookie("_memphone", Encrypt.Encode(user.Mobile.ToString(), "SmartShop"));
                        #endregion
                        result.Code = 1;
                        result.Message = "登录成功";
                    }
                }
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}