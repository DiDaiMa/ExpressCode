using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model;

namespace ExpressCode.Services.Admin.Org
{
    public class OrgTreeOutput:BaseEntity
    {
        public string Name { get; set; }
        public string ParentId { get; set; }
    }
}
