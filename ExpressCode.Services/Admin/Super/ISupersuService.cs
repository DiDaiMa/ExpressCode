using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Super
{
  public  interface ISupersuService<T>
    {
        /// <summary>
        /// 数据权限模块的显示
        /// </summary>
        /// <returns></returns>
        List<T> Index(string SourceCode);
        /// <summary>
        /// 数据权限模块的删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Delete(string Id);
        /// <summary>
        ///数据权限模块的停用
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Update(string Id, bool Enable);
        /// <summary>
        /// 根据Id查找数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<T> Cha(string Id);
    }
}
