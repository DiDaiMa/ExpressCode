using ExpressCode.Model.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.IRepository
{
    public interface IResourceRepository
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        List<ResourceEntity> ResourceShow();

        /// <summary>
        /// 显示资源管理
        /// </summary>
        /// <param name="name"></param>
        /// <param name="AppName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<ResourceEntity> GetResources(string name, string appId, int pageIndex, int pageSize, out int totalCount);
        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int UpdateState(string Id);
        /// <summary>
        /// 批删
        /// </summary>
        /// <param name="Ids"></param>
        /// <returns></returns>
        int DeleteResource(string Ids);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        int EditResource(ResourceEntity r);
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        int AddResource(ResourceEntity r);

    }
}
