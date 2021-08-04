using ExpressCode.IRepository;
using ExpressCode.Model.Admin;
using ExpressCode.Services.Admin.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Category
{
  public class CategoryService : BaseService, ICategoryService
  {
    public ICategoryTypeRepository Repository { get; set; }

    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="cat"></param>
    /// <returns></returns>
    public int Adds(CategoryTypeGetInPut cat)
    {

      var entityDto = Mapper.Map<CategoryType>(cat);
      int i = Repository.Add(entityDto);
      return i;
    }

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int Dels(int id)
    {
      int i = Repository.Del(id);
      return i;
    }

    /// <summary>
    /// 显示
    /// </summary>
    /// <returns></returns>
    public List<CategoryTypeGetOutPut> Shows()
    {
      var de = Repository.Show();
      var ads = Mapper.Map<List<CategoryTypeGetOutPut>>(de);

      return ads;
    }
  }
}
