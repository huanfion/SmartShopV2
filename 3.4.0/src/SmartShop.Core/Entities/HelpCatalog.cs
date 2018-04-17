using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //HelpCatalog
        public class HelpCatalog:Entity
    {
    
           
        /// <summary>
        /// ParentID
        /// </summary>
        public virtual int? ParentID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Name
        /// </summary>
        public virtual string Name
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
        /// Icon
        /// </summary>
        public virtual string Icon
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
         
           
                public HelpCatalog()
        {
        
        }
   
    }
    
}