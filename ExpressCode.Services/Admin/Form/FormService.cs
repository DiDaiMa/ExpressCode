using ExpressCode.Model;
using ExpressCode.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Form
{
    public class FormService :BaseService, IFormService
    {
        public IFormRepository formRepository { get; set; }

        /// <summary>
        /// 表单模块的显示 
        /// </summary>
        /// <returns></returns>
        public List<FormOutput> GetFormList()
        {
            var da= formRepository.GetFormList();
            var entityDto = Mapper.Map<List<FormOutput>>(da);
            return entityDto;
        }
        /// <summary>
        /// 表单模块的批删
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(string ids)
        {
            var da = formRepository.Delete(ids);
            return da;
        }

        /// <summary>
        /// 表单模块的添加
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int Add(FormAddInput u)
        {
           var d= Mapper.Map<FormEntity>(u);
            int i = formRepository.Add(d);
            return i;
        }
        /// <summary>
        /// 表单模块的编辑
        /// </summary>
        /// <returns></returns>
        public int Edit(FormEditInput u)
        {
            var d = Mapper.Map<FormEntity>(u);
            int i = formRepository.Edit(d);
            return i;
        }
    }
}
