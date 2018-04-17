using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //HTRoleInGroup
        public class HTRoleInGroup:Entity
    {
    
          /// <summary>
        /// RoleID
        /// </summary>
        public virtual int RoleID
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
         
           
                public HTRoleInGroup()
        {
        
        }
   
    }
    
}