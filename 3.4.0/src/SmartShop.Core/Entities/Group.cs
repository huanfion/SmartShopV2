using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //Groups
        public class Group:Entity
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
        /// CompanyID
        /// </summary>
        public virtual int? CompanyID
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
         
           
        /// <summary>
        /// IsChecked
        /// </summary>
        public virtual bool IsChecked
        {
            get; 
            set; 
        } 
         
           
                public Group()
        {
        
        }
   
    }
    
}