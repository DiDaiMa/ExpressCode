using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Model.Admin
{
    public class FlowInstance
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 流程实例模板ID
        /// </summary>
        public string InstanceSchemeId { get; set; }
        /// <summary>
        /// 实例编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 自定义名
        /// </summary>
        public string CustomName { get; set; }
        /// <summary>
        /// 当前节点ID
        /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
        /// 当前节点类型
        /// </summary>
        public int ActivityType { get; set; }
        /// <summary>
        /// 当前节点名称
        /// </summary>
        public string ActivityName { get; set; }
        /// <summary>
        /// 前一个ID
        /// </summary>
        public string PreviousId { get; set; }
        /// <summary>
        /// 流程模板内容
        /// </summary>
        public string SchemeContent { get; set; }
        /// <summary>
        /// 流程模板ID
        /// </summary>
        public string SchemeId { get; set; }
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string DbName { get; set; }
        /// <summary>
        /// 表单数据
        /// </summary>
        public string FrmData { get; set; }
        /// <summary>
        /// 表单类型
        /// </summary>
        public int FrmType { get; set; }
        /// <summary>
        /// 表单中控件属性描述
        /// </summary>
        public string FrmContentData { get; set; }
        /// <summary>
        /// 表单控件位置模板
        /// </summary>
        public string FrmContentParse { get; set; }
        /// <summary>
        /// 表单ID
        /// </summary>
        public string FrmId { get; set; }
        /// <summary>
        /// 流程类型
        /// </summary>
        public string SchemeType { get; set; }
        /// <summary>
        /// 有效标志
        /// </summary>
        public int Disabled { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 创建用户主键
        /// </summary>
        public string CreateUserId { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int FlowLevel { get; set; }
        /// <summary>
        /// 实例备注
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 是否完成
        /// </summary>
        public int IsFinish { get; set; }
        /// <summary>
        /// 执行人
        /// </summary>
        public string MakerList { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string OrgId { get; set; }
    }
}
