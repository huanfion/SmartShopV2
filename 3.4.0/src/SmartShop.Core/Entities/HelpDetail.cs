using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //HelpDetails
        public class HelpDetail:Entity
    {
           
        /// <summary>
        /// CatalogId
        /// </summary>
        public virtual int? CatalogId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Type
        /// </summary>
        public virtual int? Type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Title
        /// </summary>
        public virtual string Title
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
        /// Answer
        /// </summary>
        public virtual string Answer
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UpdateTime
        /// </summary>
        public virtual DateTime? UpdateTime
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
         
           
                public HelpDetail()
        {
        
        }
   
    }
    
}