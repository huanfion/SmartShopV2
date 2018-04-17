using Abp.Domain.Repositories;
using SmartShop.Core.Entities;
using SmartShop.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.ShopProductApp
{
    public class ShopProductAppService:SmartShopAppServiceBase,IShopProductAppService
    {
        private readonly IRepository<ShopProduct> _shopProductRepository;
        private readonly IRepository<ShopCart> _shopCartRepository;

        //通过泛型的IRepository进行了构造函数的依赖注入
        public ShopProductAppService(
            IRepository<ShopProduct> shopProductRepository
            ,IRepository<ShopCart> shopCartRepository)
        {
            _shopProductRepository = shopProductRepository;
            _shopCartRepository = shopCartRepository;
        }
        /// <summary>
        /// 查找所有商品
        /// </summary>
        /// <returns></returns>
        public List<ShopProduct> GetAllList()
        {
            return _shopProductRepository.GetAllList(p=>p.IsRecommend==1);
        }

        /// <summary>
        /// 根据id查找商品信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ShopProduct GetProductById(int Id)
        {
            return _shopProductRepository.Get(Id);
        }
    }
}
