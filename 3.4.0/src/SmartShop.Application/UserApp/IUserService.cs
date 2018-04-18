using SmartShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.UserApp
{
    /// <summary>
    /// 用户信息服务接口
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// 根据手机号码查找用户
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        HTUser GetUserByPhone(string phone);
        /// <summary>
        /// 插入用户数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int InsertUser(HTUser entity);
    }
}
