using ExpressCode.Model.Admin;
using ExpressCode.Repository.Model;
using ExpressCode.Services.Admin.ModuleElement.InPut;
using ExpressCode.Services.Admin.ModuleElement.OutPut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.ModuleElement
{
    public class ModuleElementService : BaseService, IModuleElementService
    {
        public IModuleElementRepository Repository { get; set; }
        /// <summary>
        /// 模块元素获取
        /// </summary>
        /// <returns></returns>
        public List<ModuleElementGetOutput> GetModuleElement()
        {
            var da = Repository.ModuleElementShow();
            var entityDto = Mapper.Map<List<ModuleElementGetOutput>>(da);
            return entityDto;
        }
        /// <summary>
        /// 模块元素添加
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public int ModuleLementAdd(ModuleElementPutInPut me)
        {
            var entityDto = Mapper.Map<ModuleElementEntity>(me);
            var da = Repository.ModuleLementAdd(entityDto);
            return da;
        }
        /// <summary>
        /// 模块元素删除
        /// </summary>
        /// <param name="ModuleElementId"></param>
        /// <returns></returns>
        public int ModuleLementDel(string ModuleElementId)
        {
            var da = Repository.ModuleLementDel(ModuleElementId);

            return da;
        }
        /// <summary>
        /// 模块元素修改
        /// </summary>
        /// <param name="me"></param>
        /// <returns></returns>
        public int ModuleLementPut(ModuleElementPutInPutPut me)
        {
            var entityDto = Mapper.Map<ModuleElementEntity>(me);
            var da = Repository.ModuleLementPut(entityDto);
            return da;
        }
    }
}
