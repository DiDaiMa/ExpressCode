using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Categoryfl.OutPut
{
  public class CategoryGetOutPut
  {
    public int CateId { get; set; }

    public string Name { get; set; }

    public string DtCode { get; set; }

    public string DtValue { get; set; }

    public bool Enable { get; set; }

    public int SortNo { get; set; }

    public string Description { get; set; }

    public string TypeId { get; set; }

    public DateTime CreateTime { get; set; }

    public string CreateUserName { get; set; }

    public DateTime UpdateTime { get; set; }

    public string UpdateUserName { get; set; }
  }
}
