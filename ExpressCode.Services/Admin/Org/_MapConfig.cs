using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model;

namespace ExpressCode.Services.Admin.Org
{
    public class _MapConfig: Profile
    {
        public _MapConfig()
        {
            //查询
            CreateMap<OrgEntity, OrgTreeOutput>();
            CreateMap<OrgEntity, OrgOutput>();

            //添加
            CreateMap<OrgAddInput, OrgEntity>();

            //编辑
            CreateMap<OrgEditInput, OrgEntity>();

        }
    }
}
