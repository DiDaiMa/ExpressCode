using AutoMapper;
using ExpressCode.Model.Admin;
using ExpressCode.Services.Admin.Resource.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Resource
{
    public class _MapCofig:Profile
    {
        public _MapCofig()
        {
            //显示
            CreateMap<ResourceEntity,ResourceOut>();

            //显示查询分页
            CreateMap<ResourceEntity, ResourceOutPut>();

            //修改
            CreateMap<ResouceInput, ResourceEntity>();
            //添加
            CreateMap<ResourceAddInPut, ResourceEntity>();
        }
    }
}
