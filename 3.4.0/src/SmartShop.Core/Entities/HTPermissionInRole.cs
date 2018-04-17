using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //HTPermissionInRole
        public class HTPermissionInRole:Entity
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
        /// RoleID
        /// </summary>
        public virtual int RoleID
        {
            get; 
            set; 
        } 
         
           
                public HTPermissionInRole()
        {
        
        }
   
    }
    
}