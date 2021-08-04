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
            CreateMap<FlowSchemes,FlowSchemOne>();
            CreateMap<FlowSchemIAddnput, FlowSchemes>();
        }
    }
}
