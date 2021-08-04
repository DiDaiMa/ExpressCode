using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Repository;
using ExpressCode.Model;

namespace ExpressCode.Services.Admin.User
{
    public class UserService : BaseService,IUserService
    {
        public IUserRepository Repository { get; set; }

        public int AddUser(AddUserInput user)
        {
            var UserModel = Mapper.Map<UserEntity>(user);
            var da = Repository.AddUser(UserModel);
            return da;
        }

        public int DelUser(string ids)
        {
            var da = Repository.DelUser(ids);
            return da;
        }

        public int EditUser(UserInput user)
        {
            var UserModel = Mapper.Map<UserEntity>(user);
            var da = Repository.EditUser(UserModel);
            return da;
        }

        /// <summary>
        /// 分配用户
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="orgs"></param>
        /// <returns></returns>
        public int FenUser(string ids, string orgs)
        {
            var da = Repository.FenUser(ids,orgs);
            return da;
        }

        public List<GetUserOutput> GetUsersList()
        {
            var da = Repository.GetUsersList();
            var entityDto = Mapper.Map<List<GetUserOutput>>(da);
            return entityDto;
        }
    }
}
