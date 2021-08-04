using ExpressCode.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Org
{
    public class OrgOutput:BaseEntity
    {
        [Description("节点语义ID")]
        public string CascadeId { get; set; }
        /// <summary>
        /// 功能模块名称
        /// </summary>
        [Description("名称")]
        public string Name { get; set; }

        /// <summary>
        /// 父节点流水号
        /// </summary>
        [Description("父节点流水号")]
        public string ParentId { get; set; }
        /// <summary>
        /// 父节点名称
        /// </summary>
        [Description("父节点名称")]
        public string ParentName { get; set; }
        /// <summary>
        /// 当前状态
        /// </summary>
        [Description("当前状态")]
        public int Status { get; set; }
    }
}
