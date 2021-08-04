using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

using ExpressCode.Model.Admin;
using ExpressCode.Services.Admin.Roles.Input;
using ExpressCode.Services.Admin.Roles.Output;

namespace ExpressCode.Services.Admin.Roles
{
    public class _MapConfig:Profile
    {
        public _MapConfig()
        {
            //显示
            CreateMap<RoleEntity,RoleOut>();

            //添加
            CreateMap<RoleInput, RoleEntity>();

            //编辑
            CreateMap<RoleInput, RoleEntity>();
            ////删除
            //CreateMap<RoleInput, RoleEntity>();

            //
            CreateMap<ModuleElementEntity, ModuleElementGetOutput>();

            CreateMap<ModelEntity, ModuleGetOutput>();

        }
    }
}
