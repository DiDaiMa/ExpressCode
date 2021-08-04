using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model;

namespace ExpressCode.Services.Admin.User
{
    public class GetUserOutput:BaseEntity
    {
        public string Account { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public string BizCode { get; set; }
    }
}
