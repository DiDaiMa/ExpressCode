using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Form
{
    public class FormEditInput
    {
        public string Id { get; set; }
        /// <summary>
        /// 表单名称
        /// </summary>
        [Description("表单名称")]
        public string Name { get; set; }
        /// <summary>
        /// 表单类型，0：默认动态表单；1：Web自定义表单
        /// </summary>
        [Description("表单类型，0：默认动态表单；1：Web自定义表单")]
        public int FrmType { get; set; }
        /// <summary>
        /// 系统页面标识，当表单类型为用Web自定义的表单时，需要标识加载哪个页面
        /// </summary>
        [Description("系统页面标识，当表单类型为用Web自定义的表单时，需要标识加载哪个页面")]
        public string WebId { get; set; }
        /// <summary>
        /// 字段个数
        /// </summary>
        [Description("字段个数")]
        public int Fields { get; set; }
        /// <summary>
        /// 表单中的控件属性描述
        /// </summary>
        [Description("表单中的控件属性描述")]
        public string ContentData { get; set; }
        /// <summary>
        /// 表单控件位置模板
        /// </summary>
        [Description("表单控件位置模板")]
        public string ContentParse { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [Description("备注")]
        public string Description { get; set; }
       
    }
}
