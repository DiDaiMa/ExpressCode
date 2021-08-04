using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model.Admin;

namespace ExpressCode.IRepository
{
  public interface ICategoryTypeRepository
  {
    /// <summary>
    /// 显示
    /// </summary>
    /// <returns></returns>
    List<CategoryType> Show();

    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="cat"></param>
    /// <returns></returns>
    int Add(CategoryType cat);

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    int Del(int id);
  }
}
