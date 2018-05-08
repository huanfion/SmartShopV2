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
        /// <summary>
        /// 更新购物车
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="userid"></param>
        void BindCart(string tag, int userid);
        /// <summary>
        /// 新增一条购物车记录
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        int InsertCart(ShopCart cart);

        /// <summary>
        /// 更新购物车记录
        /// </summary>
        /// <param name="cart"></param>
        void UpdateCart(ShopCart cart);

        /// <summary>
        /// 根据用户id查找购物车列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
         List<ShopCart> GetCartListByMemberId(int id);

        /// <summary>
        /// 根据tag查找购物车列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<ShopCart> GetCartListByTag(string tag);
        /// <summary>
        /// 根据id查询购物车
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ShopCart GetCartById(int id);
    }
}
