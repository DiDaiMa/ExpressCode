using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Repository.Clock
{
  public  interface IClockRepository<T>
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
        /// 定时任务批量删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Delete(string Id);
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int Add(T t);
        /// <summary>
        /// 定时任务的修改
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int Update(T t);
        /// <summary>
        /// 定时任务的根据iD查找数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<T> Cha(string Id);
    }
}
