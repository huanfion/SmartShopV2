using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //Shop_OrderDealRecord
        public class ShopOrderDealRecord:Entity
    {
        /// <summary>
        /// OrderId
        /// </summary>
        public virtual int? OrderId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AdminId
        /// </summary>
        public virtual int? AdminId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AdminName
        /// </summary>
        public virtual string AdminName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Status
        /// </summary>
        public virtual int? Status
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// StatusMessage
        /// </summary>
        public virtual string StatusMessage
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CreateTime
        /// </summary>
        public virtual DateTime? CreateTime
        {
            get; 
            set; 
        } 
         
           
                public ShopOrderDealRecord()
        {
        
        }
   
    }
    
}