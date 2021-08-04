using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Clocking
{
   public interface IClockService<T>
    {
        /// <summary>
        /// 定时任务的显示
        /// </summary>
        /// <returns></returns>
        List<T> Index(string JobName);
        /// <summary>
        /// 定时任务的启用/关闭
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Status"></param>
        /// <returns></returns>
        int UpdateShow(string Id, int Status);
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Delete(string Id);
        /// <summary>
        /// 定时任务的根据iD查找数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<T> Cha(string Id);

    }
}
