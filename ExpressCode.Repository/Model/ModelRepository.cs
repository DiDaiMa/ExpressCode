using ExpressCode.Common;
using ExpressCode.Model.Admin;
using System.Collections.Generic;

namespace ExpressCode.Repository.Model
{
    public class ModelRepository : IModelRepository
    {
        DBFactory dBFactory = new DBFactory();

        public List<ModelEntity> ModelShow()
        {
            string sql = "select * from Module";
            return dBFactory.GetBaseRepository().Query<ModelEntity>(sql);
        }
        /// <summary>
        /// 模块删除
        /// </summary>
        /// <param name="ModuleId"></param>
        /// <returns></returns>
        public int ModuleDel(string ModuleId)
        {
            string sql = $"delete from Module where Id=@Id";
            return dBFactory.GetBaseRepository().Execute(sql, new { @Id = ModuleId });
        }
        /// <summary>
        /// 模块添加
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public int ModuleAdd(ModelEntity me)
        {
            if (string.IsNullOrEmpty(me.ParentId))
            {
                string sql = $"insert into Module  values(@Id ,'',@Name ,@Url,'' ,@IsLeaf,@IsAutoExpand,@IconName,@Status,@ParentName,'',@SortNo,NULL,@Code,@IsSys)";
                return dBFactory.GetBaseRepository().Execute(sql, new
                {
                    @Id = me.Id,
                    @Name = me.Name,
                    @Url = me.Url,
                    @IsLeaf = me.IsLeaf,
                    @IsAutoExpand = me.IsAutoExpand,
                    @IconName = me.IconName,
                    @Status = me.Status,
                    @ParentName = me.ParentName,
                    @SortNo = me.SortNo,
                    @Code = me.Code,
                    @IsSys = me.IsSys
                });
            }
            string sql2 = $"insert into Module  values(@Id ,'',@Name ,@Url,'',@IsLeaf,@IsAutoExpand,@IconName,@Status,@ParentName,'',@SortNo,@ParentId,@Code,@IsSys)";
            return dBFactory.GetBaseRepository().Execute(sql2, new
            {
                @Id = me.Id,
                @Name = me.Name,
                @Url = me.Url,
                @IsLeaf = me.IsLeaf,
                @IsAutoExpand = me.IsAutoExpand,
                @IconName = me.IconName,
                @Status = me.Status,
                @ParentName = me.ParentName,
                @SortNo = me.SortNo,
                @ParentId=me.ParentId,
                @Code = me.Code,
                @IsSys = me.IsSys
            });
        }
        /// <summary>
        /// 模块修改
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public int ModulePut(ModelEntity me)
        {
            string sql = $"update  Module set Name=@Name ,Url=@Url,IsLeaf=@IsLeaf,IsAutoExpand=@IsAutoExpand,IconName=@IconName,Status=@Status,ParentName=@ParentName,SortNo=@SortNo,ParentId=@ParentId,Code=@Code,IsSys=@IsSys where Id=@Id";
            return dBFactory.GetBaseRepository().Execute(sql,new {
                @Id=me.Id,
                @Name = me.Name,
                @Url = me.Url,
                @IsLeaf = me.IsLeaf,
                @IsAutoExpand = me.IsAutoExpand,
                @IconName = me.IconName,
                @Status = me.Status,
                @ParentName = me.ParentName,
                @SortNo = me.SortNo,
                @ParentId = me.ParentId,
                @Code = me.Code,
                @IsSys = me.IsSys
            });
        }
    }
}
