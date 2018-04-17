using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //Area
        public class Area: Entity
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
        /// SortID
        /// </summary>
        public virtual int? SortID
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
         
           
                public Area()
        {
        
        }
   
    }
    
}