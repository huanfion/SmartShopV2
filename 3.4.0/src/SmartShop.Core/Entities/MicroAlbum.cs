using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //Micro_Album
        public class MicroAlbum:Entity
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
        public virtual int? Type
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
         
           
                public MicroAlbum()
        {
        
        }
   
    }
    
}