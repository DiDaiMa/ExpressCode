using ExpressCode.Model.Admin;
using ExpressCode.Repository.FlowScheme;
using ExpressCode.Services.Admin.FlowScheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.FlowScheme
{
    public class FlowSchemsService :BaseService, IFlowSchemsService
    {
        public IFlowSchemeRepository flow { get; set; }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="flow"></param>
        /// <returns></returns>
        public int AddFlow(FlowSchemIAddnput fl)
        {
            var dtoEntity= Mapper.Map<FlowSchemes>(fl);
            dtoEntity.DeleteMark = fl.Delete;
            return flow.AddFlow(dtoEntity);
        }

        /// <summary>
        /// 流程模块的显示
        /// </summary>
        /// <returns></returns>
        public List<FlowSchemOne> Index()
        {
            var b = flow.Index();
            return Mapper.Map<List<FlowSchemOne>>(b);
        }
        /// <summary>
        /// 逻辑删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int StateDelete(string Id)
        {
            int i = flow.StateDelete(Id);
            return i;
        }
    }
}
