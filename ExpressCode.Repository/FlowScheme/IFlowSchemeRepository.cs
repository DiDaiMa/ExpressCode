using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model.Admin;
namespace ExpressCode.Repository.FlowScheme
{
   public interface IFlowSchemeRepository
    {
        /// <summary>
        /// 流程设计模块的显示
        /// </summary>
        /// <returns></returns>
        List<FlowSchemes> Index();
        /// <summary>
        /// 逻辑删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int StateDelete(string ids);
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="flow"></param>
        /// <returns></returns>
        int AddFlow(FlowSchemes flow);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="flow"></param>
        /// <returns></returns>
        int EditFlow(FlowSchemes flow);
    }
}
