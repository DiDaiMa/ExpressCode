using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Repository.FlowInstanceds
{
  public  interface IFlowInstanceRepository<T>
    {
        List<T> Show();

        /// <summary>
        /// 我的流程
        /// </summary>
        /// <returns></returns>
        List<T> MyShow();
    }
}
