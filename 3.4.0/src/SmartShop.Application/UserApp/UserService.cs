using Abp.Domain.Repositories;
using SmartShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.UserApp
{
    public class UserService:IUserService
    {
        private readonly IRepository<HTUser> _userRepository;
        public UserService(IRepository<HTUser> userRepository)
        {
            this._userRepository = userRepository;
        }
        /// <summary>
        /// 根据手机号码查找用户
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public HTUser GetUserByPhone(string phone)
        {
            return _userRepository.FirstOrDefault(a => a.Mobile == phone);
        }

        /// <summary>
        /// 插入用户数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int InsertUser(HTUser entity)
        {
            return _userRepository.InsertAndGetId(entity);
        }
    }
}
