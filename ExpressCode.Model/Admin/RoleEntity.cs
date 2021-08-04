using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Model.Admin
{
    public class RoleEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateId { get; set; }
        public string TypeName { get; set; }
        public int TypeId { get; set; }
        public int DelId { get; set; } = 0;

        public string UserName { get; set; }
    }
}
