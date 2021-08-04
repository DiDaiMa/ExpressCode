using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.User
{
    [Intercept(typeof(AopTest))]
    public interface IUserService
    {
        List<GetUserOutput> GetUsersList();
        int AddUser(AddUserInput user);
        int DelUser(string ids);
        int EditUser(UserInput user);
        int FenUser(string ids, string orgs);

    }
}
