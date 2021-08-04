using ExpressCode.Common;
using ExpressCode.Model.Clocking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Repository.Clock
{
    public class ClockRepository : IClockRepository<OpenJob>
    {
        DBFactory db = new DBFactory();
        /// <summary>
        /// 定时任务的添加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Add(OpenJob t)
        {
            string sql = $"insert into OpenJob values('{t.Id=Guid.NewGuid().ToString()}','{t.JobName}',{t.RunCount},{t.ErrorCount},'{t.NextRunTime}','{t.LastRunTime}','{t.LastErrorTime}',{t.JobType},'{t.JobCall}','{t.JobCallParams}','{t.Cron}',{t.Status},'{t.Remark}','{t.CreateTime}','{t.CreateUserId}','{t.CreateUserName}','{t.UpdateTime}','{t.UpdateUserId}','{t.UpdateUserName}','{t.OrgId}')";
            return db.GetBaseRepository().Execute(sql);
        }
        /// <summary>
        /// 定时任务的根据ID查找数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<OpenJob> Cha(string Id)
        {
            string sql = $"select * from OpenJob where Id='{Id}'";
            return db.GetBaseRepository().Query<OpenJob>(sql);
        }

        /// <summary>
        /// 定时任务的删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(string Id)
        {
            int i = 0;
            string[] ss = Id.Split(',');
            foreach (var c in ss)
            {
                string sql = "delete from OpenJob where Id like @Id";
                i += db.GetBaseRepository().Execute(sql, new { @Id = c });
            }
            return i;
        }

        /// <summary>
        /// 定时任务的显示
        /// </summary>
        /// <returns></returns>
        public List<OpenJob> Index(string JobName)
        {
            string sql = "select * from OpenJob where 1=1";
            if (JobName!=null)
            {
                sql += $" and JobName like '%{JobName}%'";
            }
            List<OpenJob> opens = db.GetBaseRepository().Query<OpenJob>(sql);
            return opens;
        }
        /// <summary>
        /// 定时任务的修改
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Update(OpenJob t)
        {
            string sql = $"update OpenJob set JobName='{t.JobName}',JobType='{t.JobType}',JobCall='{t.JobCall}',JobCallParams='{t.JobCallParams}',Cron='{t.Cron}',Remark='{t.Remark}' where Id='{t.Id}'";
            return db.GetBaseRepository().Execute(sql);
        }

        /// <summary>
        /// 定时任务的启用/关闭
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Status"></param>
        /// <returns></returns>
        public int UpdateShow(string Id, int Status)
        {
            string sql = $"update OpenJob set Status={Status} where Id='{Id}'";
            return db.GetBaseRepository().Execute(sql);
        }
    }
}
