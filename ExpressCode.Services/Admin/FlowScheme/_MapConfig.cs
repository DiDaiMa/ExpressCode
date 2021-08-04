using AutoMapper;
using ExpressCode.Model.Admin;
using ExpressCode.Services.Admin.FlowScheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.FlowScheme
{
    public class _MapConfig : Profile
    {
        public _MapConfig()
        {
            //显示
            CreateMap<FlowSchemes,FlowSchemOne>();
            //添加
            CreateMap<FlowSchemIAddnput, FlowSchemes>();
            //修改
            CreateMap<FlowSchemIEditnput, FlowSchemes>();
        }
    }
}
