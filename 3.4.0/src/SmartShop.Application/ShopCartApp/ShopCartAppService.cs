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
            _shopcartRepository = shopcartRepository;
        }
        /// <summary>
        /// 获取当前用户的购物车商品数量
        /// </summary>
        /// <returns></returns>
        public int GetCountByMemberId(int MemberId)
        {
            return _shopcartRepository.GetAllList(s=>s.MemberId== MemberId).Sum(a=>a.ProductNum);
        }
        /// <summary>
        /// 获取当前cookie标识的购物车商品数量
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public int GetCartCountByCookie(string tag)
        {
            return string.IsNullOrWhiteSpace(tag) ? 0 : _shopcartRepository.GetAllList(s => s.CookieTag == tag).Sum(a => a.ProductNum);
        }
        /// <summary>
        /// 根据id查询购物车
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ShopCart GetCartById(int id)
        {
            return _shopcartRepository.Get(id);
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
        /// <summary>
        /// 根据用户id查找购物车列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ShopCart> GetCartListByMemberId(int id)
        {
            return _shopcartRepository.GetAll().Where(a => a.MemberId == id).ToList();
        }
        /// <summary>
        /// 根据tag查找购物车列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ShopCart> GetCartListByTag(string tag)
        {
            return _shopcartRepository.GetAll().Where(a => a.CookieTag == tag).ToList();
        }

        /// <summary>
        /// 更新购物车
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="userid"></param>
        public void BindCart(string tag, int userid)
        {
            var cart = _shopcartRepository.Single(a => a.CookieTag == tag);
            cart.MemberId = userid;
            _shopcartRepository.Update(cart);
        }
        /// <summary>
        /// 新增一条购物车记录
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        public int InsertCart(ShopCart cart)
        {
            return _shopcartRepository.InsertAndGetId(cart);
        }
        /// <summary>
        /// 更新购物车记录
        /// </summary>
        /// <param name="cart"></param>
        public void UpdateCart(ShopCart cart)
        {
             _shopcartRepository.Update(cart);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void RemoveCart(int id)
        {
            _shopcartRepository.Delete(id);
        }
    }
}
