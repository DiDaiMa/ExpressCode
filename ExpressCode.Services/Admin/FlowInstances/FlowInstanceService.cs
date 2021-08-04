using ExpressCode.Model.Admin;
using ExpressCode.Repository.FlowInstanceds;
using ExpressCode.Services.Admin.FlowInstances.Outs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.FlowInstances
{
    public class FlowInstanceService:BaseService,IFlowInstanceService<OutFlow>
    {
        public IFlowInstanceRepository<FlowInstance> _Flow { get; set; }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<OutFlow> FlowShow()
        {
            List<FlowInstance> FlowShow = _Flow.Show();

            var Flows = Mapper.Map<List<OutFlow>>(FlowShow);

            return Flows;
        }

        /// <summary>
        /// 我的流程显示
        /// </summary>
        /// <returns></returns>
        public List<OutFlow> FlowMyShow()
        {
            List<FlowInstance> FlowMyShow = _Flow.MyShow();

            var Flows = Mapper.Map<List<OutFlow>>(FlowMyShow);

            return Flows;
        }


    }
}
