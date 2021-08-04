using AutoMapper;
using ExpressCode.Model.Admin;
using ExpressCode.Services.Admin.Categoryfl.InPut;
using ExpressCode.Services.Admin.Categoryfl.OutPut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Categoryfl
{
  public class _MapConfig:Profile
  {
    public _MapConfig()
    {
      //查询
      CreateMap<Categorys, CategoryGetOutPut>();

      //添加
      CreateMap<CategoryGetInPut, CategoryType>();

    }
  }
}
