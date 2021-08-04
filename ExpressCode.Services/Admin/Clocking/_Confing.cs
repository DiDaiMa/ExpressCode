using AutoMapper;
using ExpressCode.Model.Clocking;
using ExpressCode.Services.Admin.Clocking.input;
using ExpressCode.Services.Admin.Clocking.output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Clocking
{
    public class _Confing : Profile
    {
        public _Confing() {
            CreateMap<OpenJob, ClockOne>();
            CreateMap<ClockTwo, OpenJob>();
        }
    }
}
