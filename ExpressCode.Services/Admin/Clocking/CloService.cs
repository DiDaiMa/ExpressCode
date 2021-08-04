using AutoMapper;
using ExpressCode.Model.Clocking;
using ExpressCode.Repository.Clock;
using ExpressCode.Services.Admin.Clocking.input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Clocking
{
    public class CloService :BaseService, ICloService<ClockTwo>
    {
        public IClockRepository<OpenJob> clock { get; set; }
        /// <summary>
        /// 定时任务的添加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Add(ClockTwo t)
        {
            var b = Mapper.Map<OpenJob>(t);
            int i = clock.Add(b);
            return i;
        }
        /// <summary>
        /// 定时任务的修改
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Update(ClockTwo t)
        {
            var b = Mapper.Map<OpenJob>(t);
            int i = clock.Update(b);
            return i;
        }
    }
}
