using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.FlowInstances
{
    public interface IFlowInstanceService<T>
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        List<T> FlowShow();

        /// <summary>
        /// 我的流程显示
        /// </summary>
        /// <returns></returns>
        List<T> FlowMyShow();

        /// <summary>
        /// 已处理流程显示
        /// </summary>
        /// <returns></returns>
        List<T> FlowDealShow();
    }
}
