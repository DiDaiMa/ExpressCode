using ExpressCode.Common;
using ExpressCode.Model.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Repository.Category
{
  public class CategoryRepository:ICategoryRepository
  {

    DBFactory dbFactory = new DBFactory();

    /// <summary>
    /// 显示分类
    /// </summary>
    /// <returns></returns>
    public List<Categorys> Show()
    {
      string str = "select * from Category";
      return dbFactory.GetBaseRepository().Query<Categorys>(str);
    }


    /// <summary>
    /// 添加分类
    /// </summary>
    public int Add(Categorys cat)
    {
      string str = $"insert into Categorys values ('{cat.CateId}','{cat.Name}','{cat.DtCode}','{cat.DtValue}',{cat.Enable},'{cat.SortNo}','{cat.Description}','{cat.TypeId}','{cat.CreateTime}','{cat.CreateUserId}','{cat.CreateUserName}','{cat.UpdateTime}','{cat.UpdateUserId}','{cat.UpdateUserName}')";
      return dbFactory.GetBaseRepository().Execute(str);
    }


    /// <summary>
    /// 删除分类
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int Del(int id)
    {
      string str = $"delete from CategoryType where ID={id}";
      return dbFactory.GetBaseRepository().Execute(str);
    }

    /// <summary>
    /// 修改分类
    /// </summary>
    /// <param name="C"></param>
    /// <returns></returns>
    public int Upt(Categorys c)
    {
      string str = $"update Staff set Name='{c.Name}',DtCode='{c.DtCode}',DtValue='{c.DtValue}',Enable='{c.Enable}',SortNo='{c.SortNo}',Description='{c.Description}',TypeId='{c.TypeId}',CreateTime='{c.CreateTime}',CreateUserId='{c.CreateUserId}',CreateUserName='{c.CreateUserName}',UpdateTime='{c.UpdateTime}',UpdateUserId='{c.UpdateUserId}',UpdateUserName='{c.UpdateUserName}'   where CateId='{c.CateId}'";
      return dbFactory.GetBaseRepository().Execute(str);
    }
  }
}
