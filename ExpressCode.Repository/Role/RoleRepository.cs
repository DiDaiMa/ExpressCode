using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Common;
using ExpressCode.IRepository;
using ExpressCode.Model.Admin;

namespace ExpressCode.Repository
{
    public class RoleRepository : IRoleRepository
    {
        DBFactory dbfactory = new DBFactory();

        public List<Dictionary<string, object>> GetModule()
        {
            //获取所有组织树
            List<ModelEntity> listAll = dbfactory.GetBaseRepository().Query<ModelEntity>("select Id,Name,ParentId from Module").ToList();
            List<ModelEntity> orgOne = listAll.Where(p => p.ParentId == null).ToList();
            List<Dictionary<string, object>> pairs = new List<Dictionary<string, object>>();
            foreach (var item in orgOne)
            {
                Dictionary<string, object> pair = new Dictionary<string, object>();
                pair.Add("id", item.Id);
                pair.Add("label", item.Name);//递归调用
                GetOrgMore(listAll, pair, item.Id);
                pairs.Add(pair);
            }
            //添加到所有字典当中
            return pairs;
        }
        /// <summary>
        /// 递归树
        /// </summary>
        /// <param name="list"></param>
        /// <param name="pair"></param>
        /// <param name="ParentTd"></param>
        public void GetOrgMore(List<ModelEntity> list, Dictionary<string, object> pair, string ParentTd)
        {
            //获取所有选出符合父Id下的教据
            List<ModelEntity> listMore = list.Where(p => p.ParentId == ParentTd).ToList();
            List<Dictionary<string, object>> pairs = new List<Dictionary<string, object>>();
            if (listMore.Count == 0)
            {
                pair.Add("children", null);
                return;
            }
            foreach (var item in listMore)
            {
                //children当中需要对象来存储,
                Dictionary<string, object> keyValue = new Dictionary<string, object>();
                keyValue.Add("id", item.Id);
                keyValue.Add("label", item.Name);
                GetOrgMore(list, keyValue, item.Id);//将对象添加阎子级的对象集合当中
                pairs.Add(keyValue);

            }
            //将子级的整个集合对象添加到—级对象中
            pair.Add("children", pairs);
        }


        /// <summary>
        /// 模块功能显示
        /// </summary>
        /// <returns></returns>
        public List<ModuleElementEntity> GetModuleElement()
        {
            string sql = $"select * from ModuleElement";

            List<ModuleElementEntity> list = dbfactory.GetBaseRepository().Query<ModuleElementEntity>(sql);

            return list;
        }
        /// <summary>
        /// 模块显示
        /// </summary>
        /// <returns></returns>
        public List<ModelEntity> GetModules()
        {
            string sql = $"select * from Module";

            List<ModelEntity> list = dbfactory.GetBaseRepository().Query<ModelEntity>(sql);

            return list;
        }



        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="Role"></param>
        /// <returns></returns>

        public int UsersAdd(RoleEntity role)
        {
            string sql = $"insert into Role values(@Id,@Name,@Status,@CreateTime,@CreateId,@TypeName,@TypeId,@DelId)";
            return dbfactory.GetBaseRepository().Execute(sql, new { @Id = Guid.NewGuid().ToString(), @Name = role.Name, @Status = role.Status, @CreateTime = System.DateTime.Now, @CreateId = role.CreateId, @TypeName = role.TypeName, @TypeId = role.TypeId, @DelId = role.DelId });
        }

        public int UsersDel(string ids)
        {
            int i = 0;
            string[] ss = ids.Split(',');
            foreach (var id in ss)
            {
                string sql = $"delete from Role where Id in (@Id)";
                i += dbfactory.GetBaseRepository().Execute(sql, new { @Id = id });
            }
            return i;
        }

        public int UsersPut(RoleEntity role)
        {
            string sql = $"update Role set Name=@Name,Status=@Status where Id=@Id";
            return dbfactory.GetBaseRepository().Execute(sql, new { @Name = role.Name, @Status = role.Status, @Id = role.Id });
        }

        public List<RoleEntity> UsersShow()
        {
            string sql = $"select * from Role";

            List<RoleEntity> list = dbfactory.GetBaseRepository().Query<RoleEntity>(sql);

            //List<RoleEntity> list1 = new List<RoleEntity>();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    list1.Add(list[i]);
            //    list.Remove(list[i]);
            //    foreach (var item1 in list1)
            //    {
            //        if (list[i].Id == item1.Id)
            //        {
            //            item1.UserName = list[i].UserName + item1.UserName;
            //            list.Remove(list[i]);
            //        }

            //    }
            //    i = -1;
            //}


            return list;
        }


        public List<Orgs> GetOrgs()
        {

            List<Orgs> list = dbfactory.GetBaseRepository().Query<Orgs>("select * from Org");

            return list;
        }

        public List<Users> GetUsers()
        {
            string sql = $"select * from Users";


            return dbfactory.GetBaseRepository().Query<Users>(sql);
        }


        public void GetOrgMore(List<Orgs> orgs, Dictionary<string, object> pair, string ParentTd)
        {
            //获取所有选出符合父Id下的教据
            List<Orgs> orgsMore = orgs.Where(p => p.ParentId == ParentTd).ToList();
            List<Dictionary<string, object>> pairs = new List<Dictionary<string, object>>();
            if (orgsMore.Count == 0)
            {
                pair.Add("children", null);
                return;
            }
            foreach (var item in orgsMore)
            {
                //children当中需要对象来存储,
                Dictionary<string, object> keyValue = new Dictionary<string, object>();
                keyValue.Add("id", item.Id);
                keyValue.Add("label", item.Name);
                GetOrgMore(orgs, keyValue, item.Id);//将对象添加阎子级的对象集合当中
                pairs.Add(keyValue);

            }
            //将子级的整个集合对象添加到—级对象中
            pair.Add("children", pairs);
        }


        public List<Dictionary<string, object>> GetOrgsTree()
        {
            //获取所有组织树
            List<Orgs> orgsAll = dbfactory.GetBaseRepository().Query<Orgs>("select * from Org").ToList();
            List<Orgs> orgOne = orgsAll.Where(p => p.ParentId == null).ToList();
            List<Dictionary<string, object>> pairs = new List<Dictionary<string, object>>();
            foreach (var item in orgOne)
            {
                Dictionary<string, object> pair = new Dictionary<string, object>();
                pair.Add("id", item.Id);
                pair.Add("label", item.Name);//递归调用
                GetOrgMore(orgsAll, pair, item.Id);
                pairs.Add(pair);
            }
            //添加到所有字典当中
            return pairs;
        }

        public int UptUserNames(Users users)
        {
            string sql = "update Users set Name=@Names where Id=@Id";

            int result = dbfactory.GetBaseRepository().Execute(sql, new { @Names = users.Name, @Id = users.Id });

            return result;
        }
    }
}
