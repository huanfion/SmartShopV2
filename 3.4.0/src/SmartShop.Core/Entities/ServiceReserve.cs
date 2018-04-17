using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //ServiceReserve
        public class ServiceReserve:Entity
    {

           
        /// <summary>
        /// SiteId
        /// </summary>
        public virtual int? SiteId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Type
        /// </summary>
        public virtual string Type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// UserName
        /// </summary>
        public virtual string UserName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Phone
        /// </summary>
        public virtual string Phone
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// City
        /// </summary>
        public virtual string City
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// District
        /// </summary>
        public virtual string District
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AccessDate
        /// </summary>
        public virtual string AccessDate
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AccessTime
        /// </summary>
        public virtual string AccessTime
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
         
           
        /// <summary>
        /// StatusMessage
        /// </summary>
        public virtual string StatusMessage
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
         
           
                public ServiceReserve()
        {
        
        }
   
    }
    
}