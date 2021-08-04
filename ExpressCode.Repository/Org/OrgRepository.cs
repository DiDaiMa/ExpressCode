using ExpressCode.Common;
using ExpressCode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Repository
{
    public class OrgRepository : IOrgRepository
    {
        //调用工厂factory
        DBFactory db = new DBFactory();


        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="orgEntity"></param>
        /// <returns></returns>
        public int AddOrg(OrgEntity orgEntity)
        {
            string sql = "";
            if (string.IsNullOrEmpty(orgEntity.ParentId))
            {
                sql = $"insert [Org] ([Id],[CascadeId],[Name],[ParentName],[Status],[CreateTime]) values" +
                $"(@Id,@CascadeId,@Name,@ParentName,@Status,'{DateTime.Now}')";
            }
            else
            {
                sql = $"insert [Org] ([Id],[CascadeId],[Name],[ParentId],[ParentName],[Status],[CreateTime]) values" +
                $"(@Id,@CascadeId,@Name,@ParentId,@ParentName,@Status,'{DateTime.Now}')";
            }
            object param = new
            {
                @Id = orgEntity.Id,
                @CascadeId = orgEntity.CascadeId,
                @Name = orgEntity.Name,
                @ParentId = orgEntity.ParentId,
                @ParentName = orgEntity.ParentName,
                @Status = orgEntity.Status,

            };
            var data = db.GetBaseRepository().Execute(sql, param);
            return data;
        }


        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int DelOrg(string ids)
        {
            string sql = $"delete from [Org] where Id in (@ids)";
            object param = new { @ids = ids };
            var data = db.GetBaseRepository().Execute(sql, param);
            return data;
        }


        /// <summary>
        /// 编辑部门
        /// </summary>
        /// <param name="orgEntity"></param>
        /// <returns></returns>
        public int EditOrg(OrgEntity orgEntity)
        {
            string sql = "";
            if (orgEntity.ParentId == null)
            {
                sql = $"update Org set Name = @Name ,Status= @Status,ParentId=null, " +
                    $"ParentName = @ParentName  where Id=@Id";
            }
            else
            {
                sql = $"update Org set Name = @Name ,Status= @Status ,ParentId= @ParentId ," +
                    $" ParentName = @ParentName  where Id= @Id";

            }
            object param = new
            {
                @Id = orgEntity.Id,
                @CascadeId = orgEntity.CascadeId,
                @Name = orgEntity.Name,
                @ParentId = orgEntity.ParentId,
                @ParentName = orgEntity.ParentName,
                @Status = orgEntity.Status,

            };
            var data = db.GetBaseRepository().Execute(sql, param);
            return data;
        }


        /// <summary>
        /// 获取组织树形列表
        /// </summary>
        /// <returns></returns>
        public List<OrgEntity> GetList()
        {
            string sql = "select * from Org";
            var data = db.GetBaseRepository().Query<OrgEntity>(sql);
            return data;
        }



    }
}
