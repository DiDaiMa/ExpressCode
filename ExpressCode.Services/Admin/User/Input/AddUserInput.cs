using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.User
{
    public  class AddUserInput
    {
        public string Account { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public string Password { get; set; }
        public string BizCode { get; set; }    //所属机构
        public string describe { get; set; }   //描述
    }
}
