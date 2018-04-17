using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //Shop_PayOrder
        public class ShopPayOrder:Entity
    {  
        /// <summary>
        /// CompanyId
        /// </summary>
        public virtual int? CompanyId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// AdminId
        /// </summary>
        public virtual int? AdminId
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
        /// BusinPayType
        /// </summary>
        public virtual string BusinPayType
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Scenes
        /// </summary>
        public virtual string Scenes
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OtherId
        /// </summary>
        public virtual string OtherId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OrderNo
        /// </summary>
        public virtual string OrderNo
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// TotalMoney
        /// </summary>
        public virtual int? TotalMoney
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// MchId
        /// </summary>
        public virtual string MchId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ProductId
        /// </summary>
        public virtual string ProductId
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
        /// OpenId
        /// </summary>
        public virtual string OpenId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsSubscribe
        /// </summary>
        public virtual int? IsSubscribe
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// PayNo
        /// </summary>
        public virtual string PayNo
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
        /// CreateDate
        /// </summary>
        public virtual string CreateDate
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
         
           
                public ShopPayOrder()
        {
        
        }
   
    }
    
}