using ExpressCode.Common;
using ExpressCode.IRepository;
using ExpressCode.Model.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Repository
{
    public class UsersRepository : IUsersRepository
    {

        DBFactory dbfactory = new DBFactory();
        public List<Users> GetUsers(string name)
        {
            string sql = "select * from Users where 1 =1";

            if (!string.IsNullOrEmpty(name))
            {
                sql += $"and Names like '%{name}%'";
            }

            return dbfactory.GetBaseRepository().Query<Users>(sql);
        }

        public int UptUserNames(Users users)
        {
            string sql = "update Users set Name=@Names where Id=@Id";

            int result = dbfactory.GetBaseRepository().Execute(sql, new { @Names = users.Name, @Id = users.Id });

            return result;
        }
    }
}
