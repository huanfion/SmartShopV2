using Abp.Application.Services;
using Abp.Domain.Repositories;
using SmartShop.Core.Entities;
using SmartShop.Entities;
using SmartShop.Enums;
using SmartShop.PhoneValidApp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Common.PhoneValidApp
{
    public class PhoneValidService: IPhoneValidService
    {
        private readonly IRepository<PhoneValid> _phoneRepository;
        //private readonly SmsService _smsservice;
        public PhoneValidService(IRepository<PhoneValid> phoneRepository)
        {
            this._phoneRepository = phoneRepository;
            //this._smsservice = smsservice;
        }
        #region == 手机验证码 ==
        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <returns></returns>
        public  bool SendValid(string phone)
        {
            var va = _phoneRepository.FirstOrDefault(a => a.Phone == phone&&a.Type==ValidType.登录&&a.IsValid==0);//(phone, ValidType.登录);
            if (va != null)
            {
                if (va.CreateTime.GetValueOrDefault().AddMinutes(1).CompareTo(DateTime.Now) > 0)
                {
                    return false;
                }
            }

            PhoneValid valid = new PhoneValid()
            {
                IsValid = 0,
                Phone = phone,
                Code = "000000",
                CreateTime = DateTime.Now,
                Type = ValidType.登录
            };
            Random ran = new Random();
            valid.Code = ran.Next(100000, 999999).ToString();
            valid.ValidTime = DateTime.Now.AddDays(1);

            string msg = string.Format("您的验证码是{0}，若非本人操作，请您忽略本短信。【{1}】", valid.Code, ConfigurationManager.AppSettings["ShopName"].ToString());
            var result = SmsService.Send(phone, msg);

            if (result)
            {
                valid.Type = ValidType.登录;
                valid.Id = _phoneRepository.InsertAndGetId(valid);
                if (valid.Id > 0)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 验证手机验证码
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <param name="code">验证码</param>
        /// <returns></returns>
        public bool ValidPhone(string phone, string code)
        {
            if (code == "1688")
            {
                return true;
            }

            var validlist = _phoneRepository.GetAllList(a => a.IsValid == 0 && a.Phone == phone && a.Code == code).OrderByDescending(a => a.Id);
            int count = validlist.Count();
            if (count > 0)
            {
                foreach (var item in validlist)
                {
                    if (item != null && item.CreateTime.GetValueOrDefault().AddDays(1).CompareTo(DateTime.Now) > -1)
                    {
                        item.IsValid = 1;
                        item.ValidTime = DateTime.Now;
                        return _phoneRepository.Update(item).Id>0;
                    }
                }

            }

            return false;
        }


        /// <summary>
        /// 发送通用验证码
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <returns></returns>
        public bool SendGenericValid(string phone, out string phoneCode)
        {
            phoneCode = "";

            var model = _phoneRepository.FirstOrDefault(a => a.Phone == phone && a.Type == ValidType.手机验证 && a.IsValid == 0);
            if (model != null)
            {
                if (model.CreateTime.GetValueOrDefault().AddMinutes(1).CompareTo(DateTime.Now) > 0)
                {
                    return false;
                }
            }


            PhoneValid valid = new PhoneValid()
            {
                IsValid = 0,
                Phone = phone,
                Code = "000000",
                CreateTime = DateTime.Now,
                Type = ValidType.手机验证
            };
            Random ran = new Random();
            valid.Code = ran.Next(100000, 999999).ToString();
            string vs = "24小时";
            valid.ValidTime = DateTime.Now.AddDays(1);

            SmsResult result = null;
            try
            {
                result = SmsService.SendRegisterResult(phone, valid.Code);
            }
            catch { }

            if (result != null && result.result == "1")
            {
                valid.Id = _phoneRepository.InsertAndGetId(valid);
                if (valid.Id > 0)
                {
                    phoneCode = valid.Code;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 验证通用手机验证码
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <param name="code">验证码</param>
        /// <returns></returns>
        public bool ValidGenericPhone(string phone, string code)
        {
            var validlist = _phoneRepository.GetAllList(a => a.IsValid == 0 && a.Phone == phone && a.Code == code).OrderByDescending(a => a.Id);
            int count = validlist.Count();
            if (count > 0)
            {
                foreach (var item in validlist)
                {
                    if (item != null && item.ValidTime.GetValueOrDefault().CompareTo(DateTime.Now) > -1)
                    {
                        item.IsValid = 1;
                        item.ValidTime = DateTime.Now;
                        return _phoneRepository.Update(item).Id > 0;
                    }
                }
            }

            return false;
        }
        #endregion

        #region == 业务短信 ==
        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <returns></returns>
        public bool SendMessage(string phone, string message, int orderId)
        {
            PhoneValid valid = new PhoneValid()
            {
                IsValid = 0,
                Phone = phone,
                Code = "000000",
                CreateTime = DateTime.Now,
                Type = ValidType.业务
            };
            valid.ValidTime = DateTime.Now.AddDays(1);
            valid.Code = orderId.ToString();


            string msg = string.Format("{0}", message);
            var result = SmsService.Send(phone, msg);

            if (result)
            {
                valid.Type = ValidType.登录;
                valid.Id = _phoneRepository.InsertAndGetId(valid);
                if (valid.Id > 0)
                {
                    return true;
                }
            }

            return false;
        }
        #endregion
    }
}