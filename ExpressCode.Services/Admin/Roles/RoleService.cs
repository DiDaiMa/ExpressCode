using ExpressCode.Model.Admin;
using ExpressCode.Services.Admin.Roles.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExpressCode.IRepository;
using ExpressCode.Services.Admin.Roles.Input;

namespace ExpressCode.Services.Admin.Roles
{
    public class RoleService : BaseService, IRoleService
    {
        public IRoleRepository RoleRepository { get; set; }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>

        public int UsersAdd(RoleInput roleinput)
        {

            var adds = Mapper.Map<RoleEntity>(roleinput);

            int i = RoleRepository.UsersAdd(adds);

            return i;
    
        }

      
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int UsersPut(RoleInput roleput)
        {
            var put = Mapper.Map<RoleEntity>(roleput);

            int i = RoleRepository.UsersPut(put);

            return i;
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<RoleOut> UserssShow()
        {
            List<RoleEntity> show = RoleRepository.UsersShow();

            var shows = Mapper.Map<List<RoleOut>>(show);

            return shows;
        }
        ///// <summary>
        ///// 删除
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public int UsersDel(string[] id)
        //{
        //    int i = RoleRepository.UsersDel(id);
        //    return i;
        //}

        public List<ModuleGetOutput> GetModules()
        {
            List<ModelEntity> result = RoleRepository.GetModules();
            var entityDto = Mapper.Map<List<ModuleGetOutput>>(result);
            return entityDto;
        }

        public List<ModuleElementGetOutput> GetModuleElement()
        {
            List<ModuleElementEntity> result = RoleRepository.GetModuleElement();
            var entityDto = Mapper.Map<List<ModuleElementGetOutput>>(result);
            return entityDto;
        }
    }
}
