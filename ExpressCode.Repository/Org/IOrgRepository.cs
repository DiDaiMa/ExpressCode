using ExpressCode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Repository
{
    public interface IOrgRepository
    {
        /// <summary>
        /// Org列表
        /// </summary>
        /// <returns></returns>
        List<OrgEntity> GetList();

        int AddOrg(OrgEntity orgEntity);
        int EditOrg(OrgEntity orgEntity);
        
        int DelOrg(string ids);
    }
}
