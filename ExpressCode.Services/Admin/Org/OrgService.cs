using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Repository;
using ExpressCode.Model;

namespace ExpressCode.Services.Admin.Org
{
    public class OrgService : BaseService, IOrgService
    {
        public IOrgRepository orgRepository { get; set; }


        public int AddOrg(OrgAddInput org)
        {
            //判断父级下面有几个子级
            int i = GetOrgList().Where(p => p.ParentName.Equals(org.ParentName)).Count();
            i = i + 1;

            if (org.ParentName != "根节点")
            {
                org.ParentId = GetOrgList().Where(p => p.Name.Equals(org.ParentName)).FirstOrDefault().Id;
                org.CascadeId = (GetOrgList().Where(p => p.Name.Equals(org.ParentName)).FirstOrDefault().CascadeId) + i + ".";
            }
            else
            {
                org.ParentId = null;
                org.CascadeId = ".0." + i + ".";
            }


            //.FirstOrDefault().CascadeId;
            var entity = Mapper.Map<OrgEntity>(org);

            return orgRepository.AddOrg(entity);
        }


        public int DelOrg(string ids)
        {
            var i = orgRepository.DelOrg(ids);
            return i;
        }


        public int EditOrg(OrgEditInput org)
        {
            
            if (string.IsNullOrEmpty(org.ParentName))
            {
                org.ParentName = "根节点";
                org.ParentId = null;
            }
            if (org.ParentName != "根节点")
            {
                org.ParentId = GetOrgList().Where(p => p.Name.Equals(org.ParentName)).FirstOrDefault().Id;
            }

            var entity = Mapper.Map<OrgEntity>(org);

            return orgRepository.EditOrg(entity);
        }


        public List<OrgOutput> GetOrgList()
        {
            var da = orgRepository.GetList();
            var entityDto = Mapper.Map<List<OrgOutput>>(da);
            return entityDto;
        }


        public List<OrgTreeOutput> GetTreeList()
        {
            var da = orgRepository.GetList();
            var entityDto = Mapper.Map<List<OrgTreeOutput>>(da);
            return entityDto;
        }
    }
}
