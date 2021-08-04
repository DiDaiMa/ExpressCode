using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Roles.Output
{
    public class ModuleElementGetOutput
    {
        public string Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Description("名称")]
        public string Name { get; set; }
        /// <summary>
        /// 功能模块Id
        /// </summary>
        [Description("功能模块Id")]
        public string ModuleId { get; set; }
    }
}
