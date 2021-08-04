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
    public interface IModelRepository
    {
        /// <summary>
        /// 模块获取
        /// </summary>
        /// <returns></returns>
        List<ModelEntity> ModelShow();
        /// <summary>
        /// 模块修改
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        int ModulePut(ModelEntity me);
        /// <summary>
        /// 模块添加
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        int ModuleAdd(ModelEntity me);
        /// <summary>
        /// 模块删除
        /// </summary>
        /// <param name="ModuleId"></param>
        /// <returns></returns>
        int ModuleDel(string ModuleId);

    }
}
