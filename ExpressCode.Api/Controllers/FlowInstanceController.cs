using ExpressCode.Model;
using ExpressCode.Model.Admin;
using ExpressCode.Repository.FlowInstanceds;
using ExpressCode.Services.Admin.FlowInstances;
using ExpressCode.Services.Admin.FlowInstances.Outs;
using ExpressCode.Services.Admin.FlowInstances.Outs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressCode.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlowInstanceController : ControllerBase
    {
        public IFlowInstanceService<OutFlow> _FlowInstanceService;
        public IFlowInstanceRepository<FlowInstance> _FlowInstanceRepository;

        public FlowInstanceController(IFlowInstanceService<OutFlow> FlowInstanceService, IFlowInstanceRepository<FlowInstance> FlowInstanceRepository) 
        {
            _FlowInstanceService = FlowInstanceService;
            _FlowInstanceRepository = FlowInstanceRepository;
        }

        [Route("FlowShow")]
        [HttpGet]
        public string FlowShow(int PageIndex,int PageSize,string name) 
        {
            int totals;
            List<OutFlow> Show = _FlowInstanceService.FlowShow();

            totals = Show.Count();

            Show = Show.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();

            if (!string.IsNullOrEmpty(name))
            {
                Show = Show.Where(p => p.CustomName.Contains(name)).ToList();
            }
            string json;

            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = new { Show,totals }
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
        /// 我的流程显示
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [Route("FlowMyShow")]
        [HttpGet]
        public string FlowMyShow(int PageIndex, int PageSize, string name)
        {
            int totals;
            List<OutFlow> Show = _FlowInstanceService.FlowMyShow();

            totals = Show.Count();

            Show = Show.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();

            if (!string.IsNullOrEmpty(name))
            {
                Show = Show.Where(p => p.CustomName.Contains(name)).ToList();
            }
            string json;

            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = new { Show, totals }
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
        /// 我的流程批删
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("FlowMyDel")]
        [HttpPost]
        public int FlowMyDel(string id)
        {
            return _FlowInstanceRepository.MyDel(id);
        }

    }
}
