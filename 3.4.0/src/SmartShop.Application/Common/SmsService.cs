using SmartShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SmartShop.Common
{
    public class SmsService
    {/// <summary>
     /// 短信发送
     /// </summary>
     /// <param name="phone">手机号码,多个号码用";"分隔</param>
     /// <param name="msg">信息内容</param>
     /// <returns></returns>
        public static bool Send(string phone, string msg)
        {
            string url = string.Format("http://113.106.16.55:8080/GateWay/Services.asmx/DirectSend?UserID={0}&Account={1}&Password={2}&Phones={3};&Content={4}&SendTime=&SendType=1&PostFixNumber=",
                "969293", "admin", "4MSCFX", phone, msg);

            string response = Utility.GetResponse(url, "", Encoding.UTF8);
            if (string.IsNullOrEmpty(response))
            {
                return false;
            }
            else
            {
                if (response.IndexOf("Sucess") > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 短信发送，服务商不同
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static SmsResult Send(Entities.SmsContext context)
        {
            string url = "http://client.sms10000.com/api/webservice";
            url += ("?" + context.ToString());
            string response = Utility.GetResponse(url, "", Encoding.UTF8);
            JavaScriptSerializer js = new JavaScriptSerializer();

            if (response != null)
            {
                try
                {
                    var obj = js.Deserialize<SmsResult>(response);
                    return obj;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                throw new Exception("对方服务器没响应");
            }

        }

        public static SmsResult SendRegisterResult(string phone, string msg)
        {
            SmsContext context = new SmsContext();
            context.MsgId = 1;
            context.Mobile = phone;
            context.Content = msg;
            return Send(context);
        }
    }
}
