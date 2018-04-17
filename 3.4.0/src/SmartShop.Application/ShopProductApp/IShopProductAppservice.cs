using Abp.Application.Services;
using SmartShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.ShopProductApp
{
    public interface IShopProductAppService: IApplicationService
    {
        /// <summary>
        /// 查找所有商品
        /// </summary>
        /// <returns></returns>
        List<ShopProduct> GetAllList();
        /// <summary>
        /// 根据id查找商品信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        ShopProduct GetProductById(int Id);
    }
}
