using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Roles.Output
{
    public class RoleOut
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public string UserName { get; set; }
    }
}
