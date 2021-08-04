using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ExpressCode.Services;
using ExpressCode.Services.Admin.Roles;
using ExpressCode.Model.Admin;
using ExpressCode.IRepository;
using ExpressCode.Services.Admin.Roles.Output;
using ExpressCode.Services.Admin.Roles.Input;
using Newtonsoft.Json;
using ExpressCode.Model;

namespace ExpressCode.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {

        //public IRoleServer RoleServer { get; set; }

        public IRoleService _server;
        private readonly IRoleRepository _RoleRepository;

        public RoleController(IRoleService RoleServer, IRoleRepository RoleRepository)
        {
            _server = RoleServer;
            _RoleRepository = RoleRepository;
        }

        /// <summary>
        /// 角色
        /// </summary>
        /// <returns></returns>
        [Route("Load")]
        [HttpGet]
        public string Load()
        {
            List<RoleOut> Show = _server.UserssShow();
            string json;

            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 200,
                msg = "请求成功",
                data = Show
            });

            if (json == null)
            {
                json = JsonConvert.SerializeObject(new ResultData
                {
                    code = 200,
                    msg = "请求失败",
                    data = ""
                });
            }

            return json;
        }


        /// <summary>
        /// 显示+分页
        /// </summary>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [Route("RoleShow")]
        [HttpGet]
        public string RoleShow(int pageindex, int pagesize, string name = "")
        {
            int total;
            List<RoleOut> Show = _server.UserssShow();
            total = Show.Count();

            Show = Show.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();

            if (!string.IsNullOrEmpty(name))
            {
                Show = Show.Where(p => p.Name.Contains(name)).ToList();
            }

            string json;

            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = new { Show, total }
            });

            if (json == null)
            {
                json = JsonConvert.SerializeObject(new ResultData
                {
                    code = 0,
                    msg = "请求失败",
                    data = ""
                });
            }

            return json;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="roleinput"></param>
        /// <returns></returns>
        [Route("RoleAdd")]
        [HttpPost]
        public string RoleAdd(RoleInput roleinput)
        {
            int i = _server.UsersAdd(roleinput);
            string json;

            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = i

            });

            if (json == null)
            {
                json = JsonConvert.SerializeObject(new ResultData
                {
                    code = 0,
                    msg = "请求失败",
                    data = ""
                });
            }

            return json;
        }

        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="roleiput"></param>
        /// <returns></returns>
        [Route("RolePut")]
        [HttpPut]
        public string RolePut(RoleInput roleiput)
        {
            RoleOut roleput = _server.UserssShow().FirstOrDefault();

            int states;

            if (roleput.Status == 0)
            {
                states = 1;
            }

            if (roleput.Status == 1)
            {
                states = 0;
            }

            int i = _server.UsersPut(roleiput);
            string json;

            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = i

            });

            if (json == null)
            {
                json = JsonConvert.SerializeObject(new ResultData
                {
                    code = 0,
                    msg = "请求失败",
                    data = ""
                });
            }

            return json;

        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("RoleDel")]
        [HttpDelete]
        public string RolePut(string id)
        {
            int i = _RoleRepository.UsersDel(id);
            string json;

            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = i

            });

            if (json == null)
            {
                json = JsonConvert.SerializeObject(new ResultData
                {
                    code = 0,
                    msg = "请求失败",
                    data = ""
                });
            }

            return json;
        }

        /// <summary>
        /// 模块显示
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetModule")]
        public string GetModule()
        {
            List<Dictionary<string, object>> list = _RoleRepository.GetModule();

            string json;

            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = list

            });

            if (json == null)
            {
                json = JsonConvert.SerializeObject(new ResultData
                {
                    code = 0,
                    msg = "请求失败",
                    data = ""
                });
            }

            return json;

        }

        [HttpGet]
        [Route("GetModules")]
        public string GetModules(string ids)
        {
            string[] iid = ids.Split(",");

            List<ModuleGetOutput> lists = new List<ModuleGetOutput>();

            List<ModuleGetOutput> list = _server.GetModules().ToList();
            if (iid != null)
            {
                foreach (var item in iid)
                {
                    lists.Add(list.Where(p => item.Equals(p.Id)).FirstOrDefault());
                }
            }

            string json;
            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = lists
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
        /// 模块功能显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetModuleElement")]
        public string GetModuleElement()
        {
            List<ModuleElementGetOutput> list = _server.GetModuleElement();

            string json;
            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = list
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

        [Route("GetOrgs")]
        [HttpGet]
        public string GetOrgs()
        {
            List<Orgs> list = _RoleRepository.GetOrgs();

            string json;
            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = list
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

        [Route("GetOrgsTree")]
        [HttpGet]
        public string GetOrgsTree()
        {
            List<Dictionary<string, object>> list = _RoleRepository.GetOrgsTree();

            string json;
            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = list
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

        [Route("GetUsers")]
        [HttpGet]
        public string GetUsers(int PageIndex,int PageSize,string name)
        {

            List<Users> list = _RoleRepository.GetUsers();

            int total = list.Count();

            if (!string.IsNullOrEmpty(name))
            {
                list = list.Where(p => p.Name.Contains(name)).ToList();
            }

            list = list.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();

            string json;
            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = new {list, total } 
                
             
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
        [Route("UptUserNames")]
        [HttpPut]
        public string UptUserNames(Users users)
        {
            int result = _RoleRepository.UptUserNames(users);

            string json;
            json = JsonConvert.SerializeObject(new ResultData
            {
                code = 0,
                msg = "请求成功",
                data = result
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
    }
}
