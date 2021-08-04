using ExpressCode.Services.Admin.Categoryfl.InPut;
using ExpressCode.Services.Admin.Categoryfl.OutPut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Categoryfl
{
  public interface ICategoryflService
  {
    /// <summary>
    /// 显示
    /// </summary>
    /// <returns></returns>
    List<CategoryGetOutPut> Shows();

    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="cat"></param>
    /// <returns></returns>
    int Adds(CategoryGetInPut cat);

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    int Dels(int id);

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    int Upts(CategoryGetInPut c);

  }
}
