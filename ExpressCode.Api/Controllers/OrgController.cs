using ExpressCode.Services.Admin.Org;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressCode.Model;

namespace ExpressCode.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrgController : ControllerBase
    {
        //构造函数注入
        private readonly IOrgService _orgservice;
        public OrgController( IOrgService orgservice)
        {
            _orgservice = orgservice;
        }

        /// <summary>
        /// 显示树形列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Tree()
        {
            ResultData data = new ResultData();
            List<OrgTreeOutput> result = null;
            result = _orgservice.GetTreeList();
            
            return Ok(result);
        }
        [HttpGet]
        public IActionResult ShowTree()
        {
            ResultData data = new ResultData();
            List<OrgTreeOutput> result = null;
            result = _orgservice.GetTreeList();
            data = new ResultData
            {
                msg = "请求成功",
                code = 200,
                data = GetTrees(result, null)
            };
            return Ok(data);
        }

        private List<Dictionary<string, object>> GetTrees(List<OrgTreeOutput> result, string pid)
        {
            List<Dictionary<string, object>> diction = new List<Dictionary<string, object>>();

            List<OrgTreeOutput> Tree = result.Where(p => p.ParentId == pid).ToList();

            foreach (var item in Tree)
            {
                Dictionary<string, object> sub = new Dictionary<string, object>();
                sub.Add("value", item.Id);
                sub.Add("id", item.Name);
                sub.Add("label", item.Name);
                sub.Add("children", GetTrees(result, item.Id));

                diction.Add(sub);
            }
            return diction;
        }

        
        /// <summary>
        /// 获取Org列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetOrgList(int page,int limit,string treeId, string keyWord)
        {
            ResultData data = new ResultData();
            List<OrgOutput> result = null;
            try
            {
                result = _orgservice.GetOrgList();
                if (!string.IsNullOrEmpty(treeId))
                {
                    result = result.Where(p => p.Name.Equals(treeId)||p.ParentName.Equals(treeId)  ).ToList();
                    
                }
                if (!string.IsNullOrEmpty(keyWord))
                {
                    result = result.Where
                        (p => p.Id.Contains(keyWord) || p.ParentName.Contains(keyWord)|| p.Name.Contains(keyWord))
                        .ToList();
                }
                int total = result.Count();
                result = result.Skip((page - 1) * limit).Take(limit).ToList();

                data = new ResultData
                {
                    msg = "请求成功",
                    code = 200,
                    data = new { result, total }
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
        /// 添加部门
        /// </summary>
        /// <param name="org"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddOrg(OrgAddInput org)
        {
            ResultData data = new ResultData();

            var result = _orgservice.AddOrg(org);
            data = new ResultData
            {
                msg = "请求成功",
                code = 200,
                data = result
            };
            return Ok(data);
        }

        [HttpPut]
        public IActionResult EditOrg(OrgEditInput org)
        {
            ResultData data = new ResultData();

            var result = _orgservice.EditOrg(org);
            data = new ResultData
            {
                msg = "请求成功",
                code = 200,
                data = result
            };
            return Ok(data);
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult DelOrg(string ids)
        {
            ResultData data = new ResultData();
            int i = _orgservice.DelOrg(ids);
            data = new ResultData
            {
                msg = "请求成功",
                code = 200,
                data = i
            };
            return Ok(data);
        }
    }
}
