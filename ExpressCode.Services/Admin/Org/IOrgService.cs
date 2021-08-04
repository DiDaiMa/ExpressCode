using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Org
{
    [Intercept(typeof(AopTest))]
    
    public interface IOrgService
    {
        [TransactionCallHandler]
        int AddOrg(OrgAddInput org);

        [TransactionCallHandler]
        int EditOrg(OrgEditInput org);

        [TransactionCallHandler]
        int DelOrg(string ids );

        List<OrgTreeOutput> GetTreeList();

        List<OrgOutput> GetOrgList();

    }
}
