using SmartShop.Core.Entities;
using SmartShop.ShopCartApp;
using SmartShop.ShopProductApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartShop.Web.Controllers
{
    public class ShopController : BaseController
    {

        private readonly IShopProductAppService _productservice;
        private readonly IShopCartAppService _shopcartservice;

        public ShopController(IShopProductAppService productservice
            , IShopCartAppService shopcartservice)
        {
            _productservice = productservice;
            _shopcartservice = shopcartservice;
        }
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        // GET: Shop
        public ActionResult Index()
        {
            List<ShopProduct> list = _productservice.GetAllList();
            return View(list);
        }
        /// <summary>
        /// 获取购物车数量
        /// </summary>
        /// <returns></returns>
        public int GetCartCount()
        {
            if (assets.MemberId > 0)
            {
                return _shopcartservice.GetCountByMemberId(assets.MemberId);
            }
            return _shopcartservice.GetCartCountByCookie(assets.CookieTag);
        }
        /// <summary>
        /// 商品展示页
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public ActionResult product(int id)
        {
           ShopProduct product= _productservice.GetProductById(id);
            return View(product);
        }
        /// <summary>
        /// 添加到购物车
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public JsonResult AddCart(int productId,int sum)
        {
            int count = 0;
            var product = _productservice.GetProductById(productId);
            if(product==null)
                return Json(0, JsonRequestBehavior.AllowGet);
            ShopCart cart = new ShopCart();
            if (assets.MemberId > 0)
            {
                cart = _shopcartservice.GetCartByProductId(assets.MemberId, productId);
            }
            else {
                cart = _shopcartservice.GetCartByProductId(assets.CookieTag, productId);
            }

            if (cart == null)
            {
                //添加新品到购物车
                ShopCart newcart = new ShopCart();
                newcart.CookieTag = assets.CookieTag;
                newcart.MemberId = assets.MemberId;
                newcart.CreateTime = DateTime.Now;
                newcart.Price = product.Price;
                newcart.TotPrice=product.Price * sum;
                newcart.ProductNum = sum;
                newcart.ProductPic = product.Cover;
                int cartid=_shopcartservice.InsertCart(newcart);
            }
            else
            {
                //更新购物车
                cart.ProductNum += sum;
                cart.Price += product.Price;
                cart.TotPrice = cart.ProductNum * cart.Price;
                _shopcartservice.UpdateCart(cart);
            }

            if (assets.MemberId > 0)
            {
                count = _shopcartservice.GetCountByMemberId(assets.MemberId);
            }
            else
            {
                count = _shopcartservice.GetCartCountByCookie(assets.CookieTag);
            }
            //查找购物车数量
            return Json(count, JsonRequestBehavior.AllowGet);
        }
    }
}