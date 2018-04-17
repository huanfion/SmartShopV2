using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //HTGroups
        public class HTGroup:Entity
    {

        /// <summary>
        /// GroupName
        /// </summary>
        public virtual string GroupName
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
         
           
                public HTGroup()
        {
        
        }
   
    }
    
}