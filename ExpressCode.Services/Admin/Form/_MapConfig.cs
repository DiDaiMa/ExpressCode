using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model;

namespace ExpressCode.Services.Admin.Form
{
    public class _MapConfig: Profile
    {
        public _MapConfig()
        {
            //查询
            CreateMap<FormEntity, FormOutput>();

            //添加
            CreateMap<FormAddInput, FormEntity>();

            //编辑
            CreateMap<FormEditInput, FormEntity>();

        }
    }
}
