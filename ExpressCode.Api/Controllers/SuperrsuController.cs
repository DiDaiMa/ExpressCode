
using ExpressCode.Model;
using ExpressCode.Services.Admin.Super;
using ExpressCode.Services.Admin.Super.Add;
using ExpressCode.Services.Admin.Super.output;
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
    public class SuperrsuController : ControllerBase
    {
        ResultData da = new ResultData();
        private ISupersuService<ClockOne> supersu;
        private ISuperService<DataPrice> super;
        public SuperrsuController(ISupersuService<ClockOne> su, ISuperService<DataPrice> superService)
        {
            supersu = su;
            super = superService;
        }
        /// <summary>
        /// 数据权限的显示
        /// </summary>
        /// <returns></returns>
        [Route("ShowIndex")]
        [HttpGet]
        public ActionResult ShowIndex(string SourceCode,int pageIndex,int pageSize)
        {
            int total;
            List<ClockOne> datas = supersu.Index(SourceCode);
            total = datas.Count();
            datas = datas.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            da = new ResultData
            {
                code = 200,
                msg = "成功",
                data = new { data = datas, total = total }
            };
            return Ok(da);
        }
        /// <summary>
        /// 数据权限的删除
        /// </summary>
        [Route("DeleteShow")]
        [HttpDelete]
        public ActionResult DeleteShow(string Id)
        {
            int i = supersu.Delete(Id);
            da = new ResultData
            {
                code = 200,
                msg = "成功",
                data = i
            };
            return Ok(da);
        }
        /// <summary>
        /// 数据权限的启用/禁用
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Enable"></param>
        /// <returns></returns>
        [Route("StopUse")]
        [HttpPut]
        public ActionResult StopUse(string Id, int Enable)
        {
            bool ba = false;
            List<ClockOne> datas = supersu.Cha(Id);
            foreach (var c in datas)
            {
                if (c.Enable == true)
                {
                    ba = false;
                }
                else
                {
                    ba = true;
                }
            }
            int i = supersu.Update(Id, ba);
            da = new ResultData
            {
                code = 200,
                msg = "成功",
                data = i
            };
            return Ok(da);
        }
        /// <summary>
        /// 数据权限的修改
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        [Route("UpdateShu")]
        [HttpPut]
        public ActionResult UpdateShu(DataPrice t)
        {
            t.UpdateTime = DateTime.Now;
            t.UpdateUserId = "0000000";
            t.UpdateUserName = "罗梓";
            int i = super.Update(t);
            da = new ResultData
            {
                code = 200,
                msg = "成功",
                data = i
            };
            return Ok(da);
        }
        /// <summary>
        /// 数据权限的添加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public ActionResult Add(DataPrice t)
        {
           
            t.CreateTime = DateTime.Now;
            t.CreateUserId = "000000";
            t.CreateUserName = "罗梓";
            int i = super.Add(t);
            da = new ResultData
            {
                code = 200,
                msg = "成功",
                data = i
            };
            return Ok(da);
        }
    }
}
