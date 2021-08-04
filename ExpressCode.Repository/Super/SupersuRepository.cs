using ExpressCode.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model;
using ExpressCode.Common;
namespace ExpressCode.Repository
{

    public class SupersuRepository : ISupersuRepository<DataPrivilegeRule>
    {
        DBFactory db = new DBFactory();
        /// <summary>
        /// 数据权限模块的添加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Add(DataPrivilegeRule t)
        {
            string sql = $"insert into DataPrivilegeRule (Id,SourceCode,SubSourceCode,Description,SortNo,PrivilegeRules,Enable,CreateTime,CreateUserId,CreateUserName) values ('{Guid.NewGuid().ToString()}','{t.SourceCode}','{t.SubSourceCode}','{t.Description}',{t.SortNo},'{t.PrivilegeRules}','{t.Enable}','{t.CreateTime}','{t.CreateUserId}','{t.CreateUserName}')";
            return db.GetBaseRepository().Execute(sql);
        }

        /// <summary>
        /// 根据Id查找数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<DataPrivilegeRule> Cha(string Id)
        {
            string sql = "select * from DataPrivilegeRule where Id=@Id";
            return db.GetBaseRepository().Query<DataPrivilegeRule>(sql, new { @Id = Id });
        }
        /// <summary>
        /// 数据权限模块的删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(string Id)
        {
            int i = 0;
             string[] ss = Id.Split(',');
            foreach (var c in ss)
            {
                string sql = "delete from DataPrivilegeRule where Id like @Id";
                i += db.GetBaseRepository().Execute(sql,new { @Id=c});
            }
            return i;
        }
        /// <summary>
        /// 数据权限模块的显示
        /// </summary>
        /// <returns></returns>
        public List<DataPrivilegeRule> Index(string SourceCode)
        {
            string sql = "select * from DataPrivilegeRule where 1=1";
            if (SourceCode != null)
            {
                sql += $" and SourceCode like '%{SourceCode}%'";
            }
            return db.GetBaseRepository().Query<DataPrivilegeRule>(sql);
        }
        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Enable"></param>
        /// <returns></returns>
        public int Update(string Id,bool Enable)
        {
            string sql = $"update DataPrivilegeRule set Enable=@Enable where Id=@Id";
            return db.GetBaseRepository().Execute(sql, new { @Enable = Enable, @Id = Id });
        }
        /// <summary>
        /// 数据权限模块的修改
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int UpdateShu(DataPrivilegeRule t)
        {
            string sql = $"update DataPrivilegeRule set SourceCode='{t.SourceCode}',SubSourceCode='{t.SubSourceCode}',Description='{t.Description}',SortNo={t.SortNo},PrivilegeRules='{t.PrivilegeRules}',Enable='{t.Enable}',UpdateTime='{t.UpdateTime}',UpdateUserId='{t.UpdateUserId}',UpdateUserName='{t.UpdateUserName}' where Id='{t.UpdateUserId}'";
            return db.GetBaseRepository().Execute(sql);
        }
    }
}
