using ExpressCode.Services.Admin.FlowScheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.FlowScheme
{
   public interface IFlowSchemsService
    {
        /// <summary>
        /// 流程模板的显示
        /// </summary>
        /// <returns></returns>
        List<FlowSchemOne> Index();
        /// <summary>
        /// 逻辑删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int StateDelete(string Id);

        int AddFlow(FlowSchemIAddnput flow);
    }
}
