using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressCode.Services.Admin.User;
using ExpressCode.Services.Admin.Org;
using ExpressCode.Model;

namespace ExpressCode.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        //构造函数注入
        private readonly IUserService _userservice;
        public UserController(IUserService userService, IOrgService orgservice)
        {
            _userservice = userService;
        }

        /// <summary>
        /// 显示用户列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Show(int page, int limit, string BizCode,string keyWord)
        {
            ResultData data = new ResultData();
            List<GetUserOutput> result = null;
            try
            {
                result = _userservice.GetUsersList();
                if (BizCode != null)
                {
                    result = result.Where(p => p.BizCode.Contains(BizCode)).ToList();
                }
                if (keyWord!=null)
                {
                    result = result.Where
                        (p => p.BizCode.Contains(keyWord)||p.Account.Contains(keyWord)||p.Name.Contains(keyWord))
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
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddUser(AddUserInput user)
        {
            if (string.IsNullOrEmpty(user.Password))
            {
                user.Password = user.Account;
            }
            ResultData data = new ResultData();
            var result = _userservice.AddUser(user);
            data = new ResultData
            {
                msg = "请求成功",
                code = 200,
                data = result
            };
            return Ok(data);
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult EditUser(UserInput user)
        {
            
            ResultData data = new ResultData();
            var result = _userservice.EditUser(user);
            data = new ResultData
            {
                msg = "请求成功",
                code = 200,
                data = result
            };
            return Ok(data);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult DelUser(string ids)
        {
            ResultData data = new ResultData();
            var result = _userservice.DelUser(ids);
            data = new ResultData
            {
                msg = "请求成功",
                code = 200,
                data = result
            };
            return Ok(data);
        }

        /// <summary>
        /// 分配用户
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="orgs"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult FenUser(string ids,string orgs)
        {
            ResultData data = new ResultData();
            var result = _userservice.FenUser(ids,orgs);
            data = new ResultData
            {
                msg = "请求成功",
                code = 200,
                data = result
            };
            return Ok(data);
        }
    }
}
