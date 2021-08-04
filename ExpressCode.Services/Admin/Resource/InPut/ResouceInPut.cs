using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services
{
    public class ResouceInput
    {
        /// <summary>
        /// 所属应用Id
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 所属应用
        /// </summary>
        public string AppName { get; set; }
        /// <summary>
        /// 主键
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        public bool Disable { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
