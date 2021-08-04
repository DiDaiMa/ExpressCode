using ExpressCode.IRepository;
using ExpressCode.Model.Admin;
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
    public class UsersController : ControllerBase
    {
        public readonly IUsersRepository _user;
        public UsersController(IUsersRepository user)
        {
            _user = user;
        }

        [Route("GetUsers")]
        [HttpGet]
        public IActionResult GetUsers(string name, int page = 1, int limit = 5)
        {
            List<Users> list = _user.GetUsers(name);

            int total = list.Count;

            list = list.Skip((page - 1) * limit).Take(limit).ToList();

            return Ok(new { code = 200, data = list, count = total });
        }

        [Route("UptUserNames")]
        [HttpPut]
        public IActionResult UptUserNames(Users users)
        {
            int result = _user.UptUserNames(users);

            return Ok(result);
        }
    }
}
