using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services
{
    public class ResourceOutPut
    {
        public string Id { get; set; }
        public int SortNo { get; set; } = 0;
        public string Description { get; set; }
        public string AppId { get; set; }
        public string AppName { get; set; }
        public string TypeName { get; set; }
        public bool Disable { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateUserName { get; set; }
        public DateTime UpdateTime { get; set; }
        public string UpdateUserName { get; set; }
        public string CascadeId { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
        public string ParentName { get; set; }
    }
}
