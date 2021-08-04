using ExpressCode.Model.Clocking;
using ExpressCode.Repository.Clock;
using ExpressCode.Services.Admin.Clocking.output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Clocking
{
    public class ClockService :BaseService, IClockService<ClockOne>
    {
        public IClockRepository<OpenJob> clock { get; set; }
        /// <summary>
        /// 根据用户Id查找数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        public List<ClockOne> Cha(string Id)
        {
            var da = clock.Cha(Id);
            return Mapper.Map<List<ClockOne>>(da);
        }
        /// <summary>
        /// 定时任务的批量删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(string Id)
        {
            var da = clock.Delete(Id);
            return da;
        }

        /// <summary>
        /// 定时任务的显示
        /// </summary>
        /// <param name="JobName"></param>
        /// <returns></returns>
        public List<ClockOne> Index(string JobName)
        {
            var d = clock.Index(JobName);
            return Mapper.Map<List<ClockOne>>(d);

        }
        /// <summary>
        /// 定时任务的启用/关闭
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Status"></param>
        /// <returns></returns>
        public int UpdateShow(string Id, int Status)
        {
            int da = clock.UpdateShow(Id, Status);
            return da;
        }
        
    }
}
