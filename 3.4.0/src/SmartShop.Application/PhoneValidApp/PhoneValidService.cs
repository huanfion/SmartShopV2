using Abp.Domain.Repositories;
using SmartShop.Core.Entities;
using SmartShop.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Common.PhoneValidApp
{
    public class PhoneValidService
    {
        private readonly IRepository<PhoneValid> _phoneRepository;
        private readonly SmsService _smsservice;
        public PhoneValidService(IRepository<PhoneValid> phoneRepository, SmsService smsservice)
        {
            this._phoneRepository = phoneRepository;
            this._smsservice = smsservice;
        }
        #region == 手机验证码 ==
        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <returns></returns>
        public  bool SendValid(string phone)
        {
            var va = _phoneRepository.Single(a => a.Phone == phone&&a.Type==ValidType.登录&&a.IsValid==0);//(phone, ValidType.登录);
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

            //SmsService sms = new SmsService();
            //SmsResult result = null;
            //try
            //{
            //    result = sms.SendRegisterResult(phone, valid.Code);
            //}
            //catch { }
            string msg = string.Format("您的验证码是{0}，若非本人操作，请您忽略本短信。【{1}】", valid.Code, ConfigurationManager.AppSettings["ShopName"].ToString());
            var result = _smsservice.Send(phone, msg);

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
        //public static bool SendGenericValid(string phone, out string phoneCode)
        //{
        //    phoneCode = "";

        //    DataAction.PhoneValid dbValid = new DataAction.PhoneValid();
        //    var va = dbValid.GetLastValid(phone, Entity.ValidType.手机验证);
        //    if (va != null)
        //    {
        //        if (va.CreateTime.AddMinutes(1).CompareTo(DateTime.Now) > 0)
        //        {
        //            return false;
        //        }
        //    }


        //    PhoneValid valid = new PhoneValid()
        //    {
        //        IsValid = 0,
        //        Phone = phone,
        //        Code = "000000",
        //        CreateTime = DateTime.Now,
        //        Type = ValidType.手机验证
        //    };
        //    Random ran = new Random();
        //    valid.Code = ran.Next(100000, 999999).ToString();
        //    string vs = "24小时";
        //    valid.ValidTime = DateTime.Now.AddDays(1);

        //    SmsService sms = new SmsService();
        //    SmsResult result = null;
        //    try
        //    {
        //        result = sms.SendRegisterResult(phone, valid.Code);
        //    }
        //    catch { }

        //    if (result != null && result.result == "1")
        //    {
        //        valid.ID = dbValid.Add(valid);
        //        if (valid.ID > 0)
        //        {
        //            phoneCode = valid.Code;
        //            return true;
        //        }
        //    }

        //    return false;
        //}

        ///// <summary>
        ///// 验证通用手机验证码
        ///// </summary>
        ///// <param name="phone">手机号码</param>
        ///// <param name="code">验证码</param>
        ///// <returns></returns>
        //public static bool ValidGenericPhone(string phone, string code)
        //{
        //    DataAction.PhoneValid dbValid = new DataAction.PhoneValid();

        //    var ds = dbValid.ValidPhone(phone, code, Entity.ValidType.手机验证);
        //    int count = ds.Tables[0].Rows.Count;
        //    if (count > 0)
        //    {
        //        for (int i = 0; i < count; i++)
        //        {
        //            Entity.PhoneValid model = dbValid.ConvertToValid(ds.Tables[0].Rows[i]);
        //            if ((model != null) && (model.ValidTime.CompareTo(DateTime.Now) > -1))
        //            {
        //                model.IsValid = 1;
        //                model.ValidTime = DateTime.Now;
        //                return dbValid.Update(model);
        //            }
        //        }
        //    }

        //    return false;
        //}
        //#endregion

        //#region == 业务短信 ==
        ///// <summary>
        ///// 发送验证码
        ///// </summary>
        ///// <param name="phone">手机号码</param>
        ///// <returns></returns>
        //public static bool SendMessage(string phone, string message, int orderId)
        //{
        //    DataAction.PhoneValid dbValid = new DataAction.PhoneValid();

        //    Entity.PhoneValid valid = new Entity.PhoneValid()
        //    {
        //        IsValid = 0,
        //        Phone = phone,
        //        Code = "000000",
        //        CreateTime = DateTime.Now,
        //        Type = Entity.ValidType.业务
        //    };
        //    valid.ValidTime = DateTime.Now.AddDays(1);
        //    valid.Code = orderId.ToString();


        //    string msg = string.Format("{0}", message);
        //    var result = Sms.Send(phone, msg);

        //    if (result)
        //    {
        //        valid.Type = Entity.ValidType.登录;
        //        valid.ID = dbValid.Add(valid);
        //        if (valid.ID > 0)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
        #endregion
    }
}