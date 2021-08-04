using ExpressCode.Model;
using ExpressCode.Services.Admin.Clocking;
using ExpressCode.Services.Admin.Clocking.input;
using ExpressCode.Services.Admin.Clocking.output;
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
    public class ClockController : ControllerBase
    {
        ResultData da = new ResultData();
        private IClockService<ClockOne> clock;
        private ICloService<ClockTwo> clo;
        /// <summary>
        /// 构造方法注入
        /// </summary>
        /// <param name="service"></param>
        public ClockController(IClockService<ClockOne> service, ICloService<ClockTwo> service1)
        {
            clock = service;
            clo = service1;

        }
        /// <summary>
        /// 定时任务的显示
        /// </summary>
        /// <param name="JobName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [Route("ClockIndex")]
        [HttpGet]
        public ActionResult ClockIndex(string JobName, int pageIndex = 1, int pageSize = 2)
        {
            int total;
            List<ClockOne> clocks = clock.Index(JobName);
            total = clocks.Count();
            clocks = clocks.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            da = new ResultData {
                code = 200,
                msg = "成功",
                data = new { data = clocks, total = total }
            };
               
            return Ok(da);
    }
        /// <summary>
        /// 定时任务的停用/启动
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Status"></param>
        /// <returns></returns>
        [Route("UpdateShow")]
        [HttpPut]
        public ActionResult UpdateShow(string Id, int Status)
        {
            int i = clock.UpdateShow(Id, Status);
            da = new ResultData
            {
                code = 200,
                msg = "成功",
                data = i
            };
            return Ok(da);
        }
        /// <summary>
        /// 定时任务的批量删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("Delete")]
        [HttpDelete]
        public ActionResult Delete(string Id)
        {
            int i = clock.Delete(Id);
            da = new ResultData {
                code = 200,
                msg = "成功",
                data = i
        };
            return Ok(da) ;
        }
        /// <summary>
        /// 定时任务的添加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public ActionResult Add(ClockTwo t)
        {
            t.RunCount = 200;
            t.ErrorCount = 200;
            t.NextRunTime = DateTime.Now;
            t.LastRunTime = DateTime.Now;
            t.LastErrorTime = DateTime.Now;
            t.Status = 1;
            t.CreateTime = DateTime.Now;
            t.CreateUserId = "000000000";
            t.CreateUserName = "罗梓";
            t.UpdateTime = DateTime.Now;
            t.UpdateUserId = "0000000";
            t.UpdateUserName = "罗梓";
            t.OrgId = "技术科";
            int i = clo.Add(t);
            da = new ResultData
            {
                code = 200,
                msg = "成功",
                data = i
            };
            return Ok(da);
        }
        /// <summary>
        /// 定时任务的修改
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        [Route("Update")]
        [HttpPut]
        public ActionResult Update(ClockTwo t)
        {
            int i = clo.Update(t);
            da = new ResultData
            {
                code = 200,
                msg = "成功",
                data = i
            };
            return Ok(da);
        }
        /// <summary>
        /// 定时任务的根据Id查找值
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("ChaZhao")]
        [HttpGet]
        public ActionResult ChaZhao(string Id)
        {
            List<ClockOne> clocks = clock.Cha(Id);
            da = new ResultData
            {
                code = 200,
                msg = "成功",
                data = clocks
            };
            return Ok(da);
        }
    }
   
}
