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
    public class ResourceRepository : IResourceRepository
    {
        DBFactory dbFactory = new DBFactory();
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<ResourceEntity> ResourceShow()
        {
            string sql = $"select * from Resource";
            return dbFactory.GetBaseRepository().Query<ResourceEntity>(sql);
        }

        /// <summary>
        /// 显示资源管理
        /// </summary>
        /// <param name="name"></param>
        /// <param name="AppName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public List<ResourceEntity> GetResources(string name, string appId, int pageIndex, int pageSize, out int totalCount)
        {
            string sql = "select * from Resource";

            List<ResourceEntity> list = dbFactory.GetBaseRepository().Query<ResourceEntity>(sql);

            if (!string.IsNullOrEmpty(name))
            {
                list = list.Where(p => p.Name.Contains(name)).ToList();
            }
            if (!string.IsNullOrEmpty(appId))
            {
                list = list.Where(p => p.AppId.Equals(appId)).ToList();
            }
            totalCount = list.Count;

            return list.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int UpdateState(string Id)
        {
            string sql = "update Resource set Disable=1 where Id=@Id";

            return dbFactory.GetBaseRepository().Execute(sql, new { @Id = Id });
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        public int DeleteResource(string ids)
        {
            string[] arr = ids.Split(",");
            int i = 0;
            foreach (var item in arr)
            {
                string sql = "delete from [Resource] where Id=@id";
                i += dbFactory.GetBaseRepository().Execute(sql, new { @id = item });
            }
            return i;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        public int EditResource(ResourceEntity r)
        {
            string sql = "update Resource set AppId=@AppId,AppName=@AppName,Name=@Name,Disable=@Disable,Description=@Description,UpdateTime=@UpdateTime where Id=@Id";

            return dbFactory.GetBaseRepository().Execute(sql, new { @AppId = r.AppId, @AppName = r.AppName, @Name = r.Name, @Disable = r.Disable, @Description = r.Description, @UpdateTime = DateTime.Now, @Id = r.Id });
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int AddResource(ResourceEntity r)
        {
            string sql_search = "select CascadeId from [Resource] order by CascadeId desc";
            ResourceEntity list = dbFactory.GetBaseRepository().Query<ResourceEntity>(sql_search).FirstOrDefault();
            string[] arr = list.CascadeId.Split('.');

            int a2 = Convert.ToInt32(arr[2]);
            string sql = "insert into  Resource (Id, CascadeId, Name, SortNo, Description, ParentName, ParentId, AppId, AppName, TypeName, TypeId, Disable, CreateTime, CreateUserId, CreateUserName, UpdateTime, UpdateUserId, UpdateUserName) VALUES " +
                "(@id,@CascadeId,@Name,@SortNo,@Description,@ParentName,@ParentId,@AppId,@AppName,@TypeName,@TypeId,@Disable,@CreateTime,@CreateUserId,@CreateUserName,@UpdateTime,@UpdateUserId,@UpdateUserName)";

            return dbFactory.GetBaseRepository().Execute(sql, new
            {
                @id = r.Id,
                @CascadeId = "." + arr[1] + "." + (a2 + 1) + ".",
                @Name = r.Name,
                @SortNo = r.SortNo,
                @Description = r.Description,
                @ParentName = "根节点",
                @ParentId = r.ParentId,
                @AppId = r.AppId,
                @AppName = r.AppName,
                @TypeName = r.TypeName,
                @TypeId = r.TypeId,
                @Disable = r.Disable,
                @CreateTime = DateTime.Now,
                @CreateUserId = "00000000-0000-0000-0000-000000000000",
                @CreateUserName = "超级管理员",
                @UpdateTime = DateTime.Now,
                @UpdateUserId = "",
                @UpdateUserName = ""
            }); ;
        }
    }
}
