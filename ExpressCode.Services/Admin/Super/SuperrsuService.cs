using ExpressCode.Common;
using ExpressCode.IRepository;
using ExpressCode.Model;
using ExpressCode.Services.Admin.Super.output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Super
{
    public class SuperrsuService : BaseService, ISupersuService<ClockOne>
    {
        public ISupersuRepository<DataPrivilegeRule> supersu { get; set; }
        /// <summary>
        /// 根据商品Id查找数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<ClockOne> Cha(string Id)
        {
            var da = supersu.Cha(Id);
            return Mapper.Map<List<ClockOne>>(da);
        }
        /// <summary>
        /// 根据商品Id做一个删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(string Id)
        {
            int da = supersu.Delete(Id);
            return da;
        }
        /// <summary>
        /// 商品模块的显示
        /// </summary>
        /// <returns></returns>
        public List<ClockOne> Index(string SourceCode)
        {
            var da = supersu.Index(SourceCode);
            return Mapper.Map<List<ClockOne>>(da);
        }
        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Enable"></param>
        /// <returns></returns>
        public int Update(string Id, bool Enable)
        {
            int i = supersu.Update(Id, Enable);
            return i;
        }
    }
}
