using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //Micro_AlbumPhoto
        public class MicroAlbumPhoto:Entity
    {
        /// <summary>
        /// AlbumId
        /// </summary>
        public virtual int? AlbumId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PhotoPath
        /// </summary>
        public virtual string PhotoPath
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Remark
        /// </summary>
        public virtual string Remark
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsDelete
        /// </summary>
        public virtual int? IsDelete
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsUse
        /// </summary>
        public virtual int? IsUse
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
         
           
                public MicroAlbumPhoto()
        {
        
        }
   
    }
    
}