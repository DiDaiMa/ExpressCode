using AutoMapper;
using ExpressCode.Model.Admin;
using ExpressCode.Services.Admin.FlowInstances.Outs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.FlowInstances
{
    public class _MapConfig:Profile
    {
        public _MapConfig()
        {
            //显示
            CreateMap<FlowInstance, OutFlow>();
        }
    }
}
