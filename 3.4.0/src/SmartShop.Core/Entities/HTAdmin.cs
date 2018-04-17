using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //HTAdmins
        public class HTAdmin:Entity
    {
    
        /// <summary>
        /// CompanyID
        /// </summary>
        public virtual int? CompanyID
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// LoginName
        /// </summary>
        public virtual string LoginName
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// LoginPassword
        /// </summary>
        public virtual string LoginPassword
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
        /// Mobile
        /// </summary>
        public virtual string Mobile
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Email
        /// </summary>
        public virtual string Email
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// QQ
        /// </summary>
        public virtual string QQ
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
        /// LastLoginTime
        /// </summary>
        public virtual DateTime? LastLoginTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// LastLoginIP
        /// </summary>
        public virtual string LastLoginIP
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// LoginCount
        /// </summary>
        public virtual int LoginCount
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ErrorCount
        /// </summary>
        public virtual int? ErrorCount
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsCompanyAdmin
        /// </summary>
        public virtual int? IsCompanyAdmin
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// LastSefetyTime
        /// </summary>
        public virtual DateTime? LastSefetyTime
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
         
           
        /// <summary>
        /// OpenId
        /// </summary>
        public virtual string OpenId
        {
            get; 
            set; 
        } 
         
           
                public HTAdmin()
        {
        
        }
   
    }
    
}