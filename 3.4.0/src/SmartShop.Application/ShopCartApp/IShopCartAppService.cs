using Abp.Application.Services;
using SmartShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.ShopCartApp
{
    public interface IShopCartAppService:IApplicationService
    {
        /// <summary>
        /// 获取购物车数量
        /// </summary>
        /// <returns></returns>
        int GetCountByMemberId(int MemberId);

        /// <summary>
        /// 获取当前cookie标识购物车数量
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        int GetCartCountByCookie(string tag);
        /// <summary>
        /// 获取指定购物车中指定的商品
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        ShopCart GetCartByProductId(int memberId, int productId);
        /// <summary>
        /// 获取指定购物车中指定的商品
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        ShopCart GetCartByProductId(string tag, int productId);
    }
}
