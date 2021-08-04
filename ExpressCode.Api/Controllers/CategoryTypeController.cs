using ExpressCode.Model.Admin;
using ExpressCode.Services.Admin.Category;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressCode.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CategoryTypeController : ControllerBase
  {
    private readonly ICategoryService _categoryTypeRepository;

    public CategoryTypeController(ICategoryService cateController)
    {
      _categoryTypeRepository = cateController;
    }

    /// <summary>
    /// 显示分类 查询
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    [Route("Show")]
    [HttpGet]
    public ActionResult Show(string name = "")
    {
      var ls = _categoryTypeRepository.Shows();
      if (!string.IsNullOrEmpty(name))
      {
        ls = ls.Where(x => x.Name.Contains(name)).ToList();
      }

      List<TreeData> d = new List<TreeData>();

      foreach (var item in ls)
      {
        TreeData tree = new TreeData();

        tree.id = item.Id;
        tree.label = item.Name;
        d.Add(tree);


      }
      return Ok(d);
      
    }

    /// <summary>
    /// 判断姓名
    /// 分类名称不能相同
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    [Route("Shows")]
    [HttpGet]
    public ActionResult Shows(string name = "")
    {
      var ls = _categoryTypeRepository.Shows();
      if (!string.IsNullOrEmpty(name))
      {
        ls = ls.Where(x => x.Name.Contains(name)).ToList();
      }
      int count = ls.Count();
      return Ok(new { msg = "", code = 0, data = count });
    }

    /// <summary>
    /// 添加分类
    /// </summary>
    /// <param name="cat"></param>
    /// <returns></returns>
    [Route("Add")]
    [HttpPost]
    public int Add(CategoryTypeGetInPut cat)
    {
      cat.CreateTime = DateTime.Now;
      return _categoryTypeRepository.Adds(cat);
    }

    /// <summary>
    /// 删除分类
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [Route("Del")]
    [HttpPost]
    public int Del(int id)
    {
      return _categoryTypeRepository.Dels(id);
    }


  }
}
