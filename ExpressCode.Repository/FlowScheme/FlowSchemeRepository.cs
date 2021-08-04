using ExpressCode.Common;
using ExpressCode.Model.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Repository.FlowScheme
{
    public class FlowSchemeRepository : IFlowSchemeRepository
    {
        DBFactory db = new DBFactory();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="flow"></param>
        /// <returns></returns>
        public int AddFlow(FlowSchemes flow)
        {
            string sql = $"insert into [FlowScheme] values"+
  $"(@id, @SchemeCode, @SchemeName, '', '', '', @SchemeContent, @FrmId, @FrmType, 0, 0, @DeleteMark, 0, @Description, @CreateDate, '', @CreateUserName, '', '', '', null)";
            object param = new
            {
                @id = flow.Id,
                @SchemeCode = flow.SchemeCode,
                @SchemeName = flow.SchemeName,
                @SchemeContent = flow.SchemeContent,
                @FrmId = flow.FrmId,
                @FrmType = flow.FrmType,
                @DeleteMark = flow.DeleteMark,
                @Description = flow.Description,
                @CreateDate = DateTime.Now,
                @CreateUserName="超级管理员"

            };
            var data= db.GetBaseRepository().Execute(sql,param);
            return data;
        }

        /// <summary>
        /// 流程模块的显示
        /// </summary>
        /// <returns></returns>
        public List<FlowSchemes> Index()
        {
            string sql = $" select * from FlowScheme where DeleteMark=0";
            return db.GetBaseRepository().Query<FlowSchemes>(sql);
        }
        /// <summary>
        /// 逻辑删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int StateDelete(string ids)
        {
            int i = 0;
            string[] ss = ids.Split(',');
            foreach (var item in ss)
            {
                string sql = $"update FlowScheme set DeleteMark=1 where Id=@item";
                i+= db.GetBaseRepository().Execute(sql,new { @item=item});
            }

            return i;
        }
    }
}
