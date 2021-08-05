using ExpressCode.Model;
using ExpressCode.Services.Admin.FlowScheme;
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
    public class FlowSchemeController : ControllerBase
    {
        private readonly IFlowSchemsService flow;
        public FlowSchemeController(IFlowSchemsService services)
        {
            flow = services;
        }
        /// <summary>
        /// 流程模块的显示
        /// </summary>
        /// <param name="SchemeName"></param>
        /// <returns></returns>
        [Route("Index")]
        [HttpGet]
        public ActionResult Index(string SchemeName)
        {
            ResultData data = new ResultData();
            try
            {
               
                List<FlowSchemOne> flows = flow.Index();
                if (SchemeName != null)
                {
                    flows = flows.Where(p => p.SchemeName.Contains(SchemeName)).ToList();
                }
                data = new ResultData
                {
                    code = 200,
                    msg = "成功",
                    data = flows
                };
            }
            catch (Exception)
            {
                data = new ResultData
                {
                    code = 500,
                    msg = "错误",
                    data = ""
                };
            }     
           
            return Ok(data);
        }
        /// <summary>
        /// 逻辑删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [Route("StateDelete")]
        [HttpPut]
        public ActionResult StateDelete(string ids)
        {
            ResultData data = new ResultData();
            try
            {
                int i = flow.StateDelete(ids);
                data = new ResultData
                {
                    code = 200,
                    msg = "成功",
                    data = i
                };
            }
            catch (Exception)
            {

                data = new ResultData
                {
                    code=500,
                    msg="失败",
                    data=0
                };
            }
            return Ok(data);
        }

        /// <summary>
        /// 添加FLow
        /// </summary>
        /// <param name="flow"></param>
        /// <returns></returns>
        [Route("AddFlow")]
        [HttpPost]
        public ActionResult AddFlow(FlowSchemIAddnput fl)
        {

            ResultData data = new ResultData();
            try
            {
                var i = flow.AddFlow(fl);
                data = new ResultData
                {
                    code = 200,
                    msg = "成功",
                    data = i
                };
            }
            catch (Exception)
            {

                data = new ResultData
                {
                    code = 500,
                    msg = "失败",
                    data = 0
                };
            }
            return Ok(data);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="fl"></param>
        /// <returns></returns>
        [Route("EditFlow")]
        [HttpPut]
        public ActionResult EditFlow(FlowSchemIEditnput fl)
        {
            ResultData data = new ResultData();
            try
            {
                var i = flow.EditFlow(fl);
                data = new ResultData
                {
                    code = 200,
                    msg = "成功",
                    data = i
                };
            }
            catch (Exception)
            {
                data = new ResultData
                {
                    code = 500,
                    msg = "失败",
                    data = 0
                };
            }
            return Ok(data);
        }
    }
}
