using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //HTRoleInAdmin
        public class HTRoleInAdmin:Entity
    {
    
          /// <summary>
        /// AdminID
        /// </summary>
        public virtual int AdminID
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
         
           
                public HTRoleInAdmin()
        {
        
        }
   
    }
    
}