using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //HTApplicationNodes
        public class HTApplicationNode:Entity
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
        /// Depth
        /// </summary>
        public virtual int Depth
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ChildCount
        /// </summary>
        public virtual int ChildCount
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// NodeName
        /// </summary>
        public virtual string NodeName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// NodeKey
        /// </summary>
        public virtual string NodeKey
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
        /// Description
        /// </summary>
        public virtual string Description
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
        /// IsLocked
        /// </summary>
        public virtual bool IsLocked
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
         
           
                public HTApplicationNode()
        {
        
        }
   
    }
    
}