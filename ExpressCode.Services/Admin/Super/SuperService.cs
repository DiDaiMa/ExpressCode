using ExpressCode.IRepository;
using ExpressCode.Model;
using ExpressCode.Services.Admin.Super.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Super
{
    public class SuperService : BaseService, ISuperService<DataPrice>
    {
        public ISupersuRepository<DataPrivilegeRule> supersu { get; set; }
        public int Add(DataPrice t)
        {
            var d = Mapper.Map<DataPrivilegeRule>(t);
            int i = supersu.Add(d);
            return i;
        }

        public int Update(DataPrice t)
        {
            var d = Mapper.Map<DataPrivilegeRule>(t);
            int i = supersu.UpdateShu(d);
            return i;
        }
    }
}
