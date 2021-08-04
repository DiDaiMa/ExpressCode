using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model;

namespace ExpressCode.Repository
{
    [Intercept(typeof(AopTest))]
    public interface IUserRepository
    {
        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        List<UserEntity> GetUsersList();

        int AddUser(UserEntity user);
        int DelUser(string ids);

        int EditUser(UserEntity user);
        int FenUser(string ids, string orgs);

    }
}
