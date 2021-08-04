using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.IRepository;
using ExpressCode.Model.Admin;
using ExpressCode.Common;

namespace ExpressCode.Repository
{
  public class CategoryTypeRepository : ICategoryTypeRepository
  {
    DBFactory dbFactory = new DBFactory();

    /// <summary>
    /// 显示分类类型
    /// </summary>
    /// <returns></returns>
    public List<CategoryType> Show()
    {
      string str = "select * from CategoryType";
      return dbFactory.GetBaseRepository().Query<CategoryType>(str);
    }


    /// <summary>
    /// 添加分类类型
    /// </summary>
    public int Add(CategoryType cat)
    {
      string str = $"insert into CategoryType values ('{cat.Id}','{cat.Name}','{cat.CreateTime}')";
      return dbFactory.GetBaseRepository().Execute(str);
    }


    /// <summary>
    /// 删除分类类型
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int Del(int id)
    {
      string str = $"delete from CategoryType where ID={id}";
      return dbFactory.GetBaseRepository().Execute(str);
    }

  }
}
