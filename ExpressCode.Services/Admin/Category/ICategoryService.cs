using ExpressCode.Services.Admin.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Category
{
  public interface ICategoryService
  {
    /// <summary>
    /// 显示
    /// </summary>
    /// <returns></returns>
    List<CategoryTypeGetOutPut> Shows();

    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="cat"></param>
    /// <returns></returns>
    int Adds(CategoryTypeGetInPut cat);

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    int Dels(int id);

  }
}
