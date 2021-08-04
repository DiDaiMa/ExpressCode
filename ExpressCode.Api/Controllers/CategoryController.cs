using ExpressCode.Services.Admin.Categoryfl;
using ExpressCode.Services.Admin.Categoryfl.InPut;
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
  public class CategoryController : ControllerBase
  {
    private readonly ICategoryflService _categoryTypeRepository;

    public CategoryController(ICategoryflService cateController)
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
        public ActionResult Show(int pageIndex, int pageSize, string name = "", string Id = "")
        {
            var ls = _categoryTypeRepository.Shows();
            if (!string.IsNullOrEmpty(name))
            {
                ls = ls.Where(x => x.Name.Contains(name)).ToList();
            }
            if (!string.IsNullOrEmpty(Id))
            {
                ls = ls.Where(x => x.TypeId.Contains(Id)).ToList();
            }
            int total = ls.Count();
            ls = ls.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            return Ok(new { msg = "", code = 0, data = ls, Count = total });
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
    public int Add(CategoryGetInPut cat)
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

    /// <summary>
    /// 修改分类
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    [Route("Upt")]
    [HttpPost]
    public int Upt(CategoryGetInPut c)
    {
      return _categoryTypeRepository.Upts(c);
    }
  }
}
