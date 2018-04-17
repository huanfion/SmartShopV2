using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //Articles
        public class Article:Entity<long>
    {
    
           
        /// <summary>
        /// ClassID
        /// </summary>
        public virtual int ClassID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ArticleType
        /// </summary>
        public virtual int ArticleType
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsContributed
        /// </summary>
        public virtual bool IsContributed
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
        /// ShortTitle
        /// </summary>
        public virtual string ShortTitle
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Click
        /// </summary>
        public virtual int Click
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Writer
        /// </summary>
        public virtual string Writer
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Source
        /// </summary>
        public virtual string Source
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// SourceUrl
        /// </summary>
        public virtual string SourceUrl
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsSlide
        /// </summary>
        public virtual bool IsSlide
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsRecommend
        /// </summary>
        public virtual bool IsRecommend
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsFeatured
        /// </summary>
        public virtual bool IsFeatured
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsHot
        /// </summary>
        public virtual bool IsHot
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// FeaturedImage
        /// </summary>
        public virtual string FeaturedImage
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
        /// Body
        /// </summary>
        public virtual string Body
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Tags
        /// </summary>
        public virtual string Tags
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UpdateTime
        /// </summary>
        public virtual DateTime UpdateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CreateTime
        /// </summary>
        public virtual DateTime CreateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// DisplayOrder
        /// </summary>
        public virtual int DisplayOrder
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Status
        /// </summary>
        public virtual int Status
        {
            get; 
            set; 
        } 
         
           
                public Article()
        {
        
        }
   
    }
    
}