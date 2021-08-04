using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.IRepository
{
    [Intercept(typeof(AopTest))]
    public interface ISupersuRepository<T>
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
        /// <summary>
        /// 数据权限模块的添加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int Add(T t);
        /// <summary>
        /// 数据权限模块的修改
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int UpdateShu(T t);
    }
}
