using ExpressCode.Model.Admin;
using ExpressCode.Services.Admin.Resource;
using ExpressCode.Services.Admin.Resource.Output;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ExpressCode.Common;
using ExpressCode.Services;
using ExpressCode.Model;

namespace ExpressCode.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private IResourceService _resourceService;

        public ResourceController(IResourceService resourceService)
        {
            _resourceService = resourceService;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        /// 
        [Route("ResourceShow")]
        [HttpGet]
        public string ResourceShow(int pageindex,int pagesize,string name="",string id="")
        {
            int total;

            List<ResourceOut> Show = _resourceService.ResouShow();

            total = Show.Count();

            Show = Show.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();

            if (!string.IsNullOrEmpty(name))
            {
                Show = Show.Where(p => p.Name.Contains(name)).ToList();
            }
            if (!string.IsNullOrEmpty(id))
            {
                Show = Show.Where(p => p.Id.Equals(id)).ToList();
            }

            string json;

            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = new { Show , total }
            });

            if (json == null)
            {



                json = JsonConvert.SerializeObject(new ResultData
                {
                    code = 0,
                    msg = "失败",
                    data = ""
                });
            }

            return json;
        }


        /// <summary>
        /// 下拉框显示
        /// </summary>
        /// <returns></returns>
        [Route("ResourceSelect")]
        [HttpGet]
        public string ResourceSelect()
        {
            List<ResourceOut> Show = _resourceService.ResouShow();
            string json;
            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = Show,
    
            });

            if (json == null)
            {
                json = JsonConvert.SerializeObject(new ResultData
                {
                    code = 0,
                    msg = "失败",
                    data = ""
                });
            }

            return json;
        }

        /// <summary>
        /// 显示资源管理
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetResource")]
        public ResultData GetResource(string name = "", string appId = "", int pageIndex = 1, int pageSize = 2)
        {
            int total;

            List<ResourceOutPut> list = _resourceService.GetResources(name, appId, pageIndex, pageSize, out total);
            ResultData resultData = new ResultData();
            try
            {
                resultData = new ResultData
                {
                    code = 200,
                    msg = "请求成功",
                    data = new { list, total }
                };
            }
            catch (Exception)
            {
                resultData = new ResultData
                {
                    code = 500,
                    msg = "请求失败",
                    data = ""
                };
            }
            return resultData;
        }
        /// <summary>
        ///  //停用
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateDisable")]
        public ResultData UpdateDisable(string id)
        {
            int i = _resourceService.UpdateDisable(id);
            ResultData resultData = new ResultData();
            if (i > 0)
            {
                resultData = new ResultData
                {
                    code = 200,
                    msg = "请求成功",
                    data = i
                };
            }
            else
            {
                resultData = new ResultData
                {
                    code = 500,
                    msg = "请求失败",
                    data = i
                };
            }
            return resultData;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteResource")]
        public ResultData DeleteResource(string ids)
        {
            int i = _resourceService.DeleteResource(ids);
            ResultData resultData = new ResultData();
            if (i > 0)
            {
                resultData = new ResultData
                {
                    code = 200,
                    msg = "请求成功",
                    data = i
                };
            }
            else
            {
                resultData = new ResultData
                {
                    code = 500,
                    msg = "请求失败",
                    data = i
                };
            }
            return resultData;
        }

        /// <summary>
        /// 修改
        /// </summary>
        [HttpPut]
        [Route("EditResource")]
        public ResultData EditResource(ResouceInput r)
        {
            int i = _resourceService.EditResource(r);
            ResultData resultData = new ResultData();
            if (i > 0)
            {
                resultData = new ResultData
                {
                    code = 200,
                    msg = "请求成功",
                    data = i
                };
            }
            else
            {
                resultData = new ResultData
                {
                    code = 500,
                    msg = "请求失败",
                    data = i
                };
            }
            return resultData;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddResource")]
        public ResultData AddResource(ResourceAddInPut r)
        {

            ResultData resultData = new ResultData();
            try
            {
                int i = _resourceService.AddResource(r);
                if (i > 0)
                {
                    resultData = new ResultData
                    {
                        code = 200,
                        msg = "请求成功",
                        data = i
                    };
                }
                else
                {
                    resultData = new ResultData
                    {
                        code = 500,
                        msg = "请求失败",
                        data = i
                    };
                }
            }
            catch (Exception ex)
            {

                resultData = new ResultData
                {
                    code = 500,
                    msg = ex.Message,
                    data = ""
                };
            }
            return resultData;
        }


    }
}
