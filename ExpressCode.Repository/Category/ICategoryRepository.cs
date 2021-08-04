using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model.Admin;

namespace ExpressCode.Repository.Category
{
  public interface ICategoryRepository
  {
    /// <summary>
    /// 显示
    /// </summary>
    /// <returns></returns>
    List<Categorys> Show();

    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="cat"></param>
    /// <returns></returns>
    int Add(Categorys cat);

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    int Del(int id);

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    int Upt(Categorys c);
  }
}
