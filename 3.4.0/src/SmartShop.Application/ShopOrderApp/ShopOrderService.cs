﻿using Abp.Domain.Repositories;
using SmartShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.ShopOrderApp
{
    public class ShopOrderService:IShopOrderService
    {
        private readonly IRepository<ShopOrder> _orderRepository;
        public ShopOrderService(IRepository<ShopOrder> orderRepository)
        {
            this._orderRepository = orderRepository;
        }


    }
}
