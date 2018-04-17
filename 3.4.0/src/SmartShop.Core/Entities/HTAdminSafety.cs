using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //HTAdminSafety
        public class HTAdminSafety:Entity
    {   
        /// <summary>
        /// AdminId
        /// </summary>
        public virtual int? AdminId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OldPassword
        /// </summary>
        public virtual string OldPassword
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// NewPassword
        /// </summary>
        public virtual string NewPassword
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
         
           
                public HTAdminSafety()
        {
        
        }
   
    }
    
}