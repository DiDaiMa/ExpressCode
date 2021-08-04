using ExpressCode.IRepository;
using ExpressCode.Model.Admin;
using ExpressCode.Services.Admin.Resource.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Resource
{
    public class ResourceService : BaseService, IResourceService
    {
        /// <summary>
        /// 函数注入
        /// </summary>
        /// <returns></returns>
        /// 
        private IResourceRepository _resourceRepository;
        public ResourceService(IResourceRepository resourceRepository)
        {
            _resourceRepository = resourceRepository;
        }


        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<ResourceOut> ResouShow()
        {
            List<ResourceEntity> ResourShow = _resourceRepository.ResourceShow();

            var show = Mapper.Map<List<ResourceOut>>(ResourShow);

            return show;
        }

        /// <summary>
        /// 显示资源管理
        /// </summary>
        /// <param name="name"></param>
        /// <param name="appName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public List<ResourceOutPut> GetResources(string name, string appId, int pageIndex, int pageSize, out int totalCount)
        {
            var list = _resourceRepository.GetResources(name, appId, pageIndex, pageSize, out totalCount);
            return Mapper.Map<List<ResourceOutPut>>(list);
        }
        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int UpdateDisable(string Id)
        {
            return _resourceRepository.UpdateState(Id);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int DeleteResource(string ids)
        {
            return _resourceRepository.DeleteResource(ids);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int EditResource(ResouceInput r)
        {
            return _resourceRepository.EditResource(Mapper.Map<ResourceEntity>(r));
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int AddResource(ResourceAddInPut r)
        {
            return _resourceRepository.AddResource(Mapper.Map<ResourceEntity>(r));
        }
    }
}
