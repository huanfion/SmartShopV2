using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //HTRoles
        public class HTRole:Entity
    {
    

           
        /// <summary>
        /// RoleName
        /// </summary>
        public virtual string RoleName
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
        /// Ico
        /// </summary>
        public virtual string Ico
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsEnabled
        /// </summary>
        public virtual bool IsEnabled
        {
            get; 
            set; 
        } 
         
           
                public HTRole()
        {
        
        }
   
    }
    
}