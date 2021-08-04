﻿using ExpressCode.Model.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Common;
namespace ExpressCode.Repository.Model
{
    public class ModuleElementRepository : IModuleElementRepository
    {
        DBFactory dBFactory = new DBFactory();

        /// <summary>
        /// 模块元素显示
        /// </summary>
        /// <returns></returns>
        public List<ModuleElementEntity> ModuleElementShow()
        {
            string sql = "select * from ModuleElement";
            return dBFactory.GetBaseRepository().Query<ModuleElementEntity>(sql);
        }
        /// <summary>
        /// 模块元素删除
        /// </summary>
        /// <param name="ModuleElementId"></param>
        /// <returns></returns>
        public int ModuleLementDel(string ModuleElementId)
        {
            string sql = $"delete from ModuleElement where Id=@Id";
            return dBFactory.GetBaseRepository().Execute(sql,new {@Id=ModuleElementId });
        }
        /// <summary>
        /// 模块元素添加
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public int ModuleLementAdd(ModuleElementEntity me)
        {

            string sql = $"insert into ModuleElement values(@Id,@DomId,@Name ,'','',@Icon,@Class,@Remark,@Sort,@ModuleId,'','')";
            return dBFactory.GetBaseRepository().Execute(sql,new { 
                @Id=me.Id,
                @DomId=me.DomId,
                @Name=me.Name,
                @Icon=me.Icon,
                @Class=me.Class,
                @Remark=me.Remark,
                @Sort=me.Sort,
                @ModuleId=me.ModuleId
            });
        }
        /// <summary>
        /// 模块元素修改
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public int ModuleLementPut(ModuleElementEntity me)
        {
            string sql = $"update ModuleElement set Name=@Name ,Icon=@Icon,Class=@Class,Remark=@Remark,Sort=@Sort,ModuleId=@ModuleId where  Id=@Id";
            return dBFactory.GetBaseRepository().Execute(sql,new {
                @Id = me.Id,
                @DomId = me.DomId,
                @Name = me.Name,
                @Icon = me.Icon,
                @Class = me.Class,
                @Remark = me.Remark,
                @Sort = me.Sort,
                @ModuleId = me.ModuleId
            });
        }

    }
}
