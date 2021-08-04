using Autofac.Extras.DynamicProxy;
using ExpressCode.Services.Admin.ModuleElement.InPut;
using ExpressCode.Services.Admin.ModuleElement.OutPut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.ModuleElement
{
    [Intercept(typeof(AopTest))]
    public interface IModuleElementService
    {
        /// <summary>
        /// 模块元素获取
        /// </summary>
        /// <returns></returns>
        List<ModuleElementGetOutput> GetModuleElement();
        /// <summary>
        /// 模块元素删除
        /// </summary>
        /// <param name="ModuleElementId"></param>
        /// <returns></returns>
        int ModuleLementDel(string ModuleElementId);
        /// <summary>
        /// 模块元素修改
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        int ModuleLementPut(ModuleElementPutInPutPut me);
        /// <summary>
        /// 模块元素添加
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        int ModuleLementAdd(ModuleElementPutInPut me);
    }
}
