using System;
using Abp.Domain.Entities;
using SmartShop.Enums;

namespace SmartShop.Core.Entities{
         //PhoneValid
        public class PhoneValid:Entity
    {

           
        /// <summary>
        /// Type
        /// </summary>
        public virtual ValidType Type
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
        /// 验证码
        /// </summary>
        public virtual string Code
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
        /// 是否已经验证
        /// </summary>
        public virtual int? IsValid
        {
            get; 
            set; 
        }


        /// <summary>
        /// 验证时间
        /// </summary>
        public virtual DateTime? ValidTime
        {
            get; 
            set; 
        } 
         
           
                public PhoneValid()
        {
        
        }
   
    }
    
}