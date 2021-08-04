using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Model
{
    [Table("Org")]
    public class OrgEntity:BaseEntity
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
        /// 热键
        /// </summary>
        [Description("热键")]
        public string HotKey { get; set; }

        /// <summary>
        /// 是否叶子节点
        /// </summary>
        [Description("是否叶子节点")]
        public bool IsLeaf { get; set; }
        /// <summary>
        /// 是否自动展开
        /// </summary>
        [Description("是否自动展开")]
        public bool IsAutoExpand { get; set; }
        /// <summary>
        /// 节点图标文件名称
        /// </summary>
        [Description("节点图标文件名称")]
        public string IconName { get; set; }
        /// <summary>
        /// 当前状态
        /// </summary>
        [Description("当前状态")]
        public int Status { get; set; }
        /// <summary>
        /// 业务对照码
        /// </summary>
        [Description("业务对照码")]
        public string BizCode { get; set; }
        /// <summary>
        /// 自定义扩展码
        /// </summary>
        [Description("自定义扩展码")]
        public string CustomCode { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Description("创建时间")]
        public System.DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建人ID
        /// </summary>
        [Description("创建人ID")]
        public int CreateId { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        [Description("排序号")]
        public int SortNo { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        [Description("分类名称")]
        public string TypeName { get; set; }
        /// <summary>
        /// 分类ID
        /// </summary>
        [Description("分类ID")]
        public string TypeId { get; set; }
    }
}
