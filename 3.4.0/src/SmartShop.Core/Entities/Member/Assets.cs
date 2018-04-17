using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities.Member
{
    public class Assets
    {
        public int Id { get; set; }
        /// <summary>
        /// 商家id
        /// </summary>
        public int MemberId { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string MemberPhone { get; set; }
        /// <summary>
        /// Cookie标识
        /// </summary>
        public string CookieTag { get; set; } = string.Empty;
    }
}
