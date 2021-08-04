using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExpressCode.Model.Admin;
using ExpressCode.Services.Admin.Roles.Input;
using ExpressCode.Services.Admin.Roles.Output;

namespace ExpressCode.Services.Admin.Roles
{
    public interface IRoleService
    {
        //添加
        int UsersAdd(RoleInput roleinput);

        //显示
        List<RoleOut> UserssShow();

        ////删除
        //int UsersDel(string id);

        //编辑
        int UsersPut(RoleInput roleput);

        List<ModuleGetOutput> GetModules();

        List<ModuleElementGetOutput> GetModuleElement();
    }
}
