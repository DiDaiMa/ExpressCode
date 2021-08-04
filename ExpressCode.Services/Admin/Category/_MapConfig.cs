using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model.Admin;

namespace ExpressCode.Services.Admin.Category
{
  public class _MapConfig:Profile
  {
    public _MapConfig()
    {
      //查询
      CreateMap<CategoryType, CategoryTypeGetOutPut>();

      //添加
      CreateMap<CategoryTypeGetInPut, CategoryType>();

    }
  }
}
