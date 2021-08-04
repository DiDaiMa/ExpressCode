using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Clocking.input
{
  public  class ClockTwo
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
        /// 异常次数
        /// </summary>
        public int ErrorCount { get; set; }
        /// <summary>
        /// 下次执行时间
        /// </summary>
        public DateTime NextRunTime { get; set; }
        /// <summary>
        /// 最后一次执行时间
        /// </summary>
        public DateTime LastRunTime { get; set; }
        /// <summary>
        /// 最后一次失败时间
        /// </summary>
        public DateTime LastErrorTime { get; set; }
        /// <summary>
        /// 任务执行方式0：本地任务：1.外部接口任务
        /// </summary>
        public int JobType { get; set; }
        /// <summary>
        /// 任务地址
        /// </summary>
        public string JobCall { get; set; }
        /// <summary>
        /// 任务参数,json格式
        /// </summary>
        public string JobCallParams { get; set; }
        /// <summary>
        /// CRON表达式
        /// </summary>
        public string Cron { get; set; }
        /// <summary>
        /// 任务运行状态(0：停止，1：正在运行，2：暂停)
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
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
        /// 最后更新人ID
        /// </summary>
        public string UpdateUserId { get; set; }
        /// <summary>
        /// 最后更新人
        /// </summary>
        public string UpdateUserName { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string OrgId { get; set; }
    }
}
