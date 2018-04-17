using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //HTPermissions
        public class HTPermission:Entity
    {
    
          /// <summary>
        /// ItemKey
        /// </summary>
        public virtual string ItemKey
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AppID
        /// </summary>
        public virtual int AppID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ItemName
        /// </summary>
        public virtual string ItemName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// DisplayOrder
        /// </summary>
        public virtual int DisplayOrder
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
         
           
                public HTPermission()
        {
        
        }
   
    }
    
}