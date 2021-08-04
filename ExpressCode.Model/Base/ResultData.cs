using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Model
{
    public class ResultData
    {
        /// <summary>
        /// 返回消息
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// 返回编号
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 返回数据
        /// </summary>
        public Object data { get; set; }

    }
}
