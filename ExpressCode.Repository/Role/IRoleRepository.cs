using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.DynamicProxy;
using ExpressCode.Model.Admin;

namespace ExpressCode.IRepository
{

    public interface IRoleRepository
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        int UsersAdd(RoleEntity role);

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        List<RoleEntity> UsersShow();

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int UsersDel(string id);

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        int UsersPut(RoleEntity role);


        List<Dictionary<string, object>> GetModule();
        /// <summary>
        /// 显示模块
        /// </summary>
        /// <returns></returns>
        List<ModelEntity> GetModules();

        /// <summary>
        /// 显示模块功能
        /// </summary>
        /// <returns></returns>
        List<ModuleElementEntity> GetModuleElement();

        List<Orgs> GetOrgs();

        List<Users> GetUsers();

        List<Dictionary<string, object>> GetOrgsTree();

        int UptUserNames(Users users);

    }
}
