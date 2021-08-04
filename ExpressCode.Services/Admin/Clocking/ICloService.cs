using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Clocking
{
  public  interface ICloService<T>
    {
        /// <summary>
        /// 定时任务的添加
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
    }
}
