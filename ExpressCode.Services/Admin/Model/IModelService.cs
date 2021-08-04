using Autofac.Extras.DynamicProxy;
using ExpressCode.Services.Admin.Model.Input;
using ExpressCode.Services.Admin.Model.Output;
using ExpressCode.Services.Admin.ModuleElement.InPut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Model
{
    [Intercept(typeof(AopTest))]
    public interface IModelService
    {
        /// <summary>
        /// 模型接口数据获取
        /// </summary>
        /// <returns></returns>
       List<ModelGetOutput> GetModel();
        /// <summary>
        /// 模型修改接口
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        int ModulePut(ModelPutInputPut me);
        /// <summary>
        /// 模型添加接口
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        int ModuleAdd(ModelPutInput me);
        /// <summary>
        /// 模型删除接口
        /// </summary>
        /// <param name="ModuleId"></param>
        /// <returns></returns>
        int ModuleDel(string ModuleId);

    }
}
