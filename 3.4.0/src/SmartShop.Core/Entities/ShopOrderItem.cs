﻿using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //Shop_OrderItem
        public class ShopOrderItem:Entity
    {
           
        /// <summary>
        /// Mode
        /// </summary>
        public virtual string Mode
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OrderID
        /// </summary>
        public virtual int? OrderID
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
        /// ProductId
        /// </summary>
        public virtual int? ProductId
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ProductNo
        /// </summary>
        public virtual string ProductNo
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ProductName
        /// </summary>
        public virtual string ProductName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ProdcutPic
        /// </summary>
        public virtual string ProdcutPic
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Quantity
        /// </summary>
        public virtual int? Quantity
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Unit
        /// </summary>
        public virtual string Unit
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Fee
        /// </summary>
        public virtual decimal? Fee
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// OriginalFee
        /// </summary>
        public virtual decimal? OriginalFee
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Readme
        /// </summary>
        public virtual string Readme
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsRemove
        /// </summary>
        public virtual int? IsRemove
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
         
           
                public ShopOrderItem()
        {
        
        }
   
    }
    
}