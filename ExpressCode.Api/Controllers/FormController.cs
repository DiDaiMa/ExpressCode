using ExpressCode.Common;
using ExpressCode.Repository;
using ExpressCode.Services.Admin.Form;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ExpressCode.Model;

namespace ExpressCode.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        //构造函数注入
        private readonly IFormService _formservice;

        public FormController(IFormService formservice)
        {
            _formservice = formservice;
        }


        /// <summary>
        /// 表单列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetFormList")]
        public IActionResult GetFormList(string keyWord,string id)
        {
            
            ResultData data = new ResultData();
            List<FormOutput> result = null;
            try
            {
                result  = _formservice.GetFormList();

                if (!string.IsNullOrEmpty(keyWord))
                {
                    result = result.Where
                        (p => p.Name.Contains(keyWord))
                        .ToList();
                }
                if (!string.IsNullOrEmpty(id))
                {
                    result = result.Where
                       (p => p.Id.Equals(id))
                       .ToList();
                }

                data = new ResultData
                {
                    msg = "请求成功",
                    code = 200,
                    data = result
                };
            }
            catch (Exception ex)
            {
                data = new ResultData
                {
                    msg = ex.Message,
                    code = 500,
                    data = ""
                };
            }
            return Ok(data);
        }

        /// <summary>
        /// 表单设计的批删
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Delete")]
        public IActionResult Delete(string id)
        {
            ResultData data = new ResultData();
            int i = _formservice.Delete(id);
            if (i > 0)
            {
                data = new ResultData
                {
                    code = 200,
                    msg = "请求成功",
                    data = i
                };
            }
            else
            {
                data = new ResultData
                {
                    code = 500,
                    msg = "请求失败",
                    data = i
                };
            }
            return Ok(data);
        }
        /// <summary>
        /// 表单设计的添加
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public ActionResult Add(FormAddInput u)
        {
            ResultData data = new ResultData();
            int i = _formservice.Add(u);
            if (i > 0)
            {
                data = new ResultData
                {
                    code = 200,
                    msg = "请求成功",
                    data = i
                };
            }
            else
            {
                data = new ResultData
                {
                    code = 500,
                    msg = "请求失败",
                    data = i
                };
            }
            return Ok(data);
        }
        /// <summary>
        /// Form 表单的修改
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Edit")]
        public ActionResult Edit(FormEditInput u)
        {
            ResultData data = new ResultData();
            int i = _formservice.Edit(u);
            if (i > 0)
            {
                data = new ResultData
                {
                    code = 200,
                    msg = "请求成功",
                    data = i
                };
            }
            else
            {
                data = new ResultData
                {
                    code = 500,
                    msg = "请求失败",
                    data = i
                };
            }
            return Ok(data);
        }

    }
}
