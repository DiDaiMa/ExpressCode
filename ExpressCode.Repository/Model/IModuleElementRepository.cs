using Autofac.Extras.DynamicProxy;
using ExpressCode.Model.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Repository.Model
{

  [Intercept(typeof(AopTest))]
  public interface IModuleElementRepository
  {
        /// <summary>
        /// 模块元素显示
        /// </summary>
        /// <returns></returns>
        List<ModuleElementEntity> ModuleElementShow();
        /// <summary>
        /// 模块元素删除
        /// </summary>
        /// <param name="ModuleElementId"></param>
        /// <returns></returns>

        int ModuleLementDel(string ModuleElementId);
        /// <summary>
        /// 模块元素添加
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>

        int ModuleLementAdd(ModuleElementEntity me);
        /// <summary>
        /// 模块元素修改
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        int ModuleLementPut(ModuleElementEntity me);
    }
}
