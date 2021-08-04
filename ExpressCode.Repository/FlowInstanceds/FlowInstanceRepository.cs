using ExpressCode.Common;
using ExpressCode.Model.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Repository.FlowInstanceds
{
    public class FlowInstanceRepository : IFlowInstanceRepository<FlowInstance>
    {
        /// <summary>
        /// 实例工厂
        /// </summary>
        DBFactory db = new DBFactory();
        /// <summary>
        /// 待处理流程显示
        /// </summary>
        /// <returns></returns>
        public List<FlowInstance> Show()
        {
            string sql = $"select * from FlowInstance where IsFinish=0";
            return db.GetBaseRepository().Query <FlowInstance>(sql);
        }

        /// <summary>
        /// 我的流程显示
        /// </summary>
        /// <returns></returns>
        public List<FlowInstance> MyShow()
        {
            string sql = $"select * from FlowInstance";
            return db.GetBaseRepository().Query<FlowInstance>(sql);
        }

        public int MyDel(string id)
        {
            int i = 0;
            string[] iid = id.Split(',');

            foreach (var ids in iid)
            {
                string sql = $"delete from FlowInstance where Id in (@Id)";
                i += db.GetBaseRepository().Execute(sql, new { @Id = ids });
            }

            return i;
        }
    }
}
