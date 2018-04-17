using Abp.Domain.Repositories;
using SmartShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.ShopCartApp
{
    public class ShopCartAppService : SmartShopAppServiceBase, IShopCartAppService
    {
        private readonly IRepository<ShopCart> _shopcartRepository;
        public ShopCartAppService(IRepository<ShopCart> shopcartRepository)
        {
            shopcartRepository = _shopcartRepository;
        }
        /// <summary>
        /// 获取当前用户的购物车商品数量
        /// </summary>
        /// <returns></returns>
        public int GetCountByMemberId(int MemberId)
        {
            return _shopcartRepository.Count(s=>s.MemberId== MemberId);
        }
        /// <summary>
        /// 获取当前cookie标识的购物车数量
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public int GetCartCountByCookie(string tag)
        {
            return string.IsNullOrWhiteSpace(tag)?0: _shopcartRepository.Count(s => s.CookieTag== tag);
        }
        /// <summary>
        /// 获取指定购物车中指定的商品
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        public ShopCart GetCartByProductId(int memberId, int productId)
        {
            return _shopcartRepository.GetAll().Where(a => a.MemberId == memberId).FirstOrDefault();
        }
        /// <summary>
        /// 获取指定购物车中指定的商品
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        public ShopCart GetCartByProductId(string tag, int productId)
        {
            return _shopcartRepository.GetAll().Where(a => a.CookieTag == tag).FirstOrDefault();
        }

    }
}
