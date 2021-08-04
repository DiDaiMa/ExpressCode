using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.FlowInstances.Outs
{
    public class OutFlow
    {
        /// <summary>
        /// Id//
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 流程实例模板Id
        /// </summary>
        public string InstanceSchemeId { get; set; }
        /// <summary>
        /// 实例编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 自定义名称
        /// </summary>
        public string CustomName { get; set; }
        /// <summary>
        /// 当前节点名称
        /// </summary>
        public string ActivityName { get; set; }
        /// <summary>
        /// 实例备注
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 是否完成
        /// </summary>
        public int IsFinish { get; set; }
    }
}
