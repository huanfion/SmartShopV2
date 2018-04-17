using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //HTPermissionInAdmin
        public class HTPermissionInAdmin:Entity
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
        /// AdminID
        /// </summary>
        public virtual int AdminID
        {
            get; 
            set; 
        } 
         
           
                public HTPermissionInAdmin()
        {
        
        }
   
    }
    
}