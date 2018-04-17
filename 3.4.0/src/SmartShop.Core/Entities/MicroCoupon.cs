using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //Micro_Coupon
        public class MicroCoupon:Entity
    {
   
        /// <summary>
        /// SiteId
        /// </summary>
        public virtual int? SiteId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Title
        /// </summary>
        public virtual string Title
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Remark
        /// </summary>
        public virtual string Remark
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
         
           
                public MicroCoupon()
        {
        
        }
   
    }
    
}