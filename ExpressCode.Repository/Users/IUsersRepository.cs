using ExpressCode.Model.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.IRepository
{
    public interface IUsersRepository
    {
        int UptUserNames(Users users);

        List<Users> GetUsers(string name);


    }
}
