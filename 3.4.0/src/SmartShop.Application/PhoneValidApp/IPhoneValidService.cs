using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.PhoneValidApp
{
    public interface IPhoneValidService : IApplicationService
    {
        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        bool SendValid(string phone);
        /// <summary>
        /// 验证手机验证码
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        bool ValidPhone(string phone, string code);
        /// <summary>
        /// 发送通用验证码
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="phoneCode"></param>
        /// <returns></returns>
        bool SendGenericValid(string phone, out string phoneCode);
        /// <summary>
        /// 验证通用手机验证码
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        bool ValidGenericPhone(string phone, string code);
        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="message"></param>
        /// <param name="orderId"></param>
        /// <returns></returns>
        bool SendMessage(string phone, string message, int orderId);
    }
}
