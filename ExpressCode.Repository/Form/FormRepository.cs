using ExpressCode.Common;
using ExpressCode.Model;
using ExpressCode.Repository.FlowScheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Repository
{
    public class FormRepository : IFormRepository
    {
        //调用工厂factory
        DBFactory db = new DBFactory();
        FlowSchemeRepository flowRepository = new FlowSchemeRepository();

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<FormEntity> GetFormList()
        {
            string sql = "select * from Form where DeleteMark=0 and Disabled=0";
            var data = db.GetBaseRepository().Query<FormEntity>(sql);
            return data;
        }
        /// <summary>
        /// 表单设计模块的批删
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(string ids)
        {
            int i = 0;
            string[] arr = ids.Split(',');
            var da = flowRepository.Index();
            foreach (var item in arr)
            {
                if (da.Where(p => p.FrmId.Equals(item)).ToList().Count == 0)
                {
                    string sql = $"update Form set DeleteMark=1 where Id=@id";
                    i += db.GetBaseRepository().Execute(sql, new { @id = item });
                }
            }
            return i;
        }
        /// <summary>
        /// Form表单的添加
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int Add(FormEntity u)
        {
            string sql = $"insert into Form (Id,Content,ContentData,ContentParse,DeleteMark,Description,Disabled,Fields,FrmType,Name,WebId,CreateDate,CreateUserId,CreateUserName,OrgId) values " +
                $"(@Id, @Content,@ContentData,@ContentParse,@DeleteMark,@Description,@Disabled, @Fields,@FrmType,@Name,@WebId,@CreateDate, @CreateUserId, @CreateUserName,@OrgId)";
            Object param = new
            {
                @Id = Guid.NewGuid().ToString(),
                @Content = u.Content,
                @ContentData = u.ContentData,
                @ContentParse = u.ContentParse,
                @DeleteMark = u.DeleteMark,
                @Description = u.Description,
                @Disabled = u.Disabled,
                @Fields = u.Fields,
                @FrmType = u.FrmType,
                @Name = u.Name,
                @WebId = u.WebId,
                @CreateDate = DateTime.Now,
                @CreateUserId = "00000000-0000-0000-0000-000000000000",
                @CreateUserName = "超级管理员",
                @OrgId = "543a9fcf-4770-4fd9-865f-030e562be238"
            };
            return db.GetBaseRepository().Execute(sql, param);
        }

        /// <summary>
        /// form 表单的修改
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int Edit(FormEntity u)
        {
            string sql = "update Form set Content=@Content,ContentData=@ContentData,ContentParse=@ContentParse,DeleteMark=@DeleteMark," +
                "Description=@Description,Disabled=@Disabled,Fields=@Fields,FrmType=@FrmType,Name=@Name,WebId=@WebId,ModifyDate=@ModifyDate," +
                "ModifyUserId=@ModifyUserId,ModifyUserName=@ModifyUserName,OrgId=@OrgId where Id=@Id";
            Object param = new
            {
                @Id = u.Id,
                @Content = u.Content,
                @ContentData = u.ContentData,
                @ContentParse = u.ContentParse,
                @DeleteMark = u.DeleteMark,
                @Description = u.Description,
                @Disabled = u.Disabled,
                @Fields = u.Fields,
                @FrmType = u.FrmType,
                @Name = u.Name,
                @WebId = u.WebId,
                @ModifyDate = DateTime.Now,
                ModifyUserId = "00000000-0000-0000-0000-000000000000",
                ModifyUserName = "超级管理员",
                @OrgId = "543a9fcf-4770-4fd9-865f-030e562be238"
            };
            return db.GetBaseRepository().Execute(sql, param);
        }

    }
}
