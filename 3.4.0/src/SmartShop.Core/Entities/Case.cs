using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //Case
        public class Case:Entity
    {
         
           
        /// <summary>
        /// Name
        /// </summary>
        public virtual string Name
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Summary
        /// </summary>
        public virtual string Summary
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Cover
        /// </summary>
        public virtual string Cover
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Url
        /// </summary>
        public virtual string Url
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
         
           
        /// <summary>
        /// DisplayOrder
        /// </summary>
        public virtual int? DisplayOrder
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Status
        /// </summary>
        public virtual int? Status
        {
            get; 
            set; 
        } 
         
           
                public Case()
        {
        
        }
   
    }
    
}