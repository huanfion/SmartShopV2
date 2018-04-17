using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //Shop_ProductClass
        public class ShopProductClass:Entity
    {
   
        /// <summary>
        /// CompanyID
        /// </summary>
        public virtual int? CompanyID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ParentID
        /// </summary>
        public virtual int? ParentID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ClassName
        /// </summary>
        public virtual string ClassName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Description
        /// </summary>
        public virtual string Description
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// DisplayOrder
        /// </summary>
        public virtual int? DisplayOrder
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsRemove
        /// </summary>
        public virtual int? IsRemove
        {
            get; 
            set; 
        } 
         
           
                public ShopProductClass()
        {
        
        }
   
    }
    
}