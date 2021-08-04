using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Common;
using ExpressCode.Model;

namespace ExpressCode.Repository
{
    public class UserRepository : IUserRepository
    {
        //调用工厂factory
        DBFactory db = new DBFactory();


        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int AddUser(UserEntity user)
        {
            string sql = $"insert Users (Id,Account,Password,Name,Status,BizCode,CreateTime) " +
                $"values(@Id,@Account,@Password,@Name,@Status,@BizCode,'{DateTime.Now}')";
            object param = new
            {
                @Id = user.Id,
                @Account = user.Account,
                @Password = user.Password,
                @Name = user.Name,
                @Status = user.Status,
                @BizCode = user.BizCode
            };
            var data = db.GetBaseRepository().Execute(sql, param);
            return data;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int DelUser(string ids)
        {
            string sql = $"delete from Users where Id in(@ids)";
            object param = new { @ids = ids };
            var data = db.GetBaseRepository().Execute(sql, param);
            return data;
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int EditUser(UserEntity user)
        {
            string sql = $"update  Users set Account=@Account,Password=@Password," +
                $"Name=@Name,Status=@Status,BizCode=@BizCode where Id=@Id";
            if (string.IsNullOrEmpty(user.Password))
            {
                sql = $"update  Users set Account=@Account," +
                $"Name=@Name,Status=@Status,BizCode=@BizCode where Id=@Id";
            }
            object param = new
            {
                @Id = user.Id,
                @Account = user.Account,
                @Password = user.Password,
                @Name = user.Name,
                @Status = user.Status,
                @BizCode = user.BizCode
            };
            var data = db.GetBaseRepository().Execute(sql, param);
            return data;
        }

        /// <summary>
        /// 分配用户
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="orgs"></param>
        /// <returns></returns>
        public int FenUser(string ids, string orgs)
        {
            string sql = $"update [Users] set BizCode=@BizCode where Id in(@ids)";
            object param = new { @ids = ids , @BizCode =orgs};
            var data = db.GetBaseRepository().Execute(sql, param);
            return data;
        }

        /// <summary>
        /// 获取用户列表 GetUsersList
        /// </summary>
        /// <returns></returns>
        public List<UserEntity> GetUsersList()
        {
            string sql = "select * from Users";
            var data = db.GetBaseRepository().Query<UserEntity>(sql);
            return data;
        }

    }
}
