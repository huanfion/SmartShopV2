using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartShop.Web.Models.Member
{
    public class SigninEditModel:BaseModel
    {
        /// <summary>
        /// 用户帐号
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 手机验证码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 记住密码
        /// </summary>
        public int cbPs { get; set; }

        /// <summary>
        /// 登录二维码编号
        /// </summary>
        public int QrCode { get; set; }
        /// <summary>
        /// 二维码标记
        /// </summary>
        public string Ticket { get; set; }
    }
}