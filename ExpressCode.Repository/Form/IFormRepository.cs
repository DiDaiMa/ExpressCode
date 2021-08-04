using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model;

namespace ExpressCode.Repository
{
  
    public interface IFormRepository
    {  
           /// <summary>
          /// 表单模块的显示
         /// </summary>
        List<FormEntity> GetFormList();
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
        int Add(FormEntity u);

        /// <summary>
        /// Form表单的编辑
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        int Edit(FormEntity u);
    }
   
}
