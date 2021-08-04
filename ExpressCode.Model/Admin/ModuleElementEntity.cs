using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Model.Admin
{
    public class ModuleElementEntity:BaseEntity
    {
        /// <summary>
        /// DOM ID	
        /// </summary>
        public string DomId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 元素附加属性
        /// </summary>
        public string Attr { get; set; }
        /// <summary>
        /// 元素调用脚本
        /// </summary>
        public string Script { get; set; }
        /// <summary>
        /// 元素图标
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// 元素样式
        /// </summary>
        public string Class { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 排序字段
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 功能模块Id
        /// </summary>
        public string ModuleId { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 分类Id
        /// </summary>
        public string TypeId { get; set; }
    }
}
