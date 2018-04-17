using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //HTPermissionInGroup
        public class HTPermissionInGroup:Entity
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
        /// GroupID
        /// </summary>
        public virtual int GroupID
        {
            get; 
            set; 
        } 
         
           
                public HTPermissionInGroup()
        {
        
        }
   
    }
    
}