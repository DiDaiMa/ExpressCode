using ExpressCode.Model.Admin;
using ExpressCode.Repository.Category;
using ExpressCode.Services.Admin.Categoryfl.InPut;
using ExpressCode.Services.Admin.Categoryfl.OutPut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Categoryfl
{
  public class CategoryflService:BaseService,ICategoryflService
  {
    public ICategoryRepository Repository { get; set; }

    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="cat"></param>
    /// <returns></returns>
    public int Adds(CategoryGetInPut cat)
    {

      var entityDto = Mapper.Map<Categorys>(cat);
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
    public List<CategoryGetOutPut> Shows()
    {
      var de = Repository.Show();
      var ads = Mapper.Map<List<CategoryGetOutPut>>(de);

      return ads;
    }

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    public int Upts(CategoryGetInPut c)
    {
      var put = Mapper.Map<Categorys>(c);
      int i = Repository.Upt(put);
      return i; ;
    }


  }
}
