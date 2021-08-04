using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.FlowScheme
{
    public class FlowSchemIAddnput
    {
        /// <summary>
        /// 流程编号
        /// </summary>
        public string SchemeCode { get; set; }
        /// <summary>
        /// 流程名称
        /// </summary>
        public string SchemeName { get; set; }



        /// <summary>
        /// 流程内容
        /// </summary>
        public string SchemeContent { get; set; }
        /// <summary>
        /// 表单Id
        /// </summary>
        public string FrmId { get; set; }
        /// <summary>
        /// 表单类型
        /// </summary>
        public int FrmType { get; set; }
        public int enabled { get; set; }
        /// <summary>
        /// 删除标记
        /// </summary>
        public int Delete { get; set; } = 0;
        /// <summary>
        /// 备注
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 所属部门
        /// </summary>
        public string OrgId { get; set; }
    }
}
