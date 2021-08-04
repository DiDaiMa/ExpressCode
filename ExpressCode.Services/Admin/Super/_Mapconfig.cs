using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model;
using ExpressCode.Services.Admin.Super.output;
using ExpressCode.Services.Admin.Super.Add;

namespace ExpressCode.Services.Admin.Super
{
    public class _MapConfig : Profile
    {
        public _MapConfig()
        {
            //查询
            CreateMap<DataPrivilegeRule, ClockOne>();
            CreateMap<DataPrice, DataPrivilegeRule>();
        }
    }
}
