using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Form
{
    public interface IFormService
    {
        /// <summary>
        /// 显示查询
        /// </summary>
        /// <returns></returns>
        List<FormOutput> GetFormList();
        /// <summary>
        /// 表单设计模块的批删
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Delete(string ids);
        /// <summary>
        /// Form表单的添加
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        int Add(FormAddInput u);
        /// <summary>
        /// Form表单的编辑
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        int Edit(FormEditInput u);

    }
}
