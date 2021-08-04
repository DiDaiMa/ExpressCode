using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Super.Add
{
  public class DataPrice
    {
        /// <summary>
        /// 数据ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 资源标识(模块标号)
        /// </summary>
        public string SourceCode { get; set; }
        /// <summary>
        /// 二级资源标识
        /// </summary>
        public string SubSourceCode { get; set; }
        /// <summary>
        /// 权限描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        public int SortNo { get; set; }
        /// <summary>
        /// 权限规则
        /// </summary>
        public string PrivilegeRules { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        public bool Enable { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建人ID
        /// </summary>
        public string CreateUserId { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 最后更新人Id
        /// </summary>
        public string UpdateUserId { get; set; }
        /// <summary>
        /// 最后更新人
        /// </summary>
        public string UpdateUserName { get; set; }
    }
}
