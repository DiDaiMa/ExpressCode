using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Roles.Output
{
    public class ModuleGetOutput
    {
        public string Id { get; set; }

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

    }
}
