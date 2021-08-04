using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Model.Admin
{
    public class Users
    {
        public string Id { get; set; }          //用户Id
        public string Account { get; set; }         //账号
        public string Password { get; set; }        //密码
        public string Name { get; set; }            //用户姓名
        public int Sex { get; set; }                //用户性别
        public int Status { get; set; }             //用户状态
        public string BizCode { get; set; }         //业务对照码
        public DateTime CreateTime { get; set; }        //经办时间
        public string CreateId { get; set; }            //创建人
        public string TypeName { get; set; }            //分类名称
        public string TypeId { get; set; }              //分类ID


    }
}
