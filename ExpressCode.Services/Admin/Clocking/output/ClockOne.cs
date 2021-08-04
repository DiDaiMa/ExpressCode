using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Clocking.output
{
  public class ClockOne
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 任务名称
        /// </summary>
        public string JobName { get; set; }
        /// <summary>
        /// 任务执行次数
        /// </summary>
        public int RunCount { get; set; }
        /// <summary>
        /// 最后一次执行时间
        /// </summary>
        public DateTime LastRunTime { get; set; }
        /// <summary>
        /// 任务地址
        /// </summary>
        public string JobCall { get; set; }
        /// <summary>
        /// CRON表达式
        /// </summary>
        public string Cron { get; set; }
        /// <summary>
        /// 任务运行状态(0：停止，1：正在运行，2：暂停)
        /// </summary>
        public int Status { get; set; }
        public string ST { get { return Status == 1 ? "正在运行" : "停止";  } }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
