﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services.Admin.Model.Output
{
    public class ModelGetOutput
    {
        public string Id { get; set; }
        public string CascadeId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string HotKey { get; set; }
        public bool IsLeaf { get; set; }
        public bool IsAutoExpand { get; set; }
        public string IconName { get; set; }
        public int Status { get; set; }
        public string ParentName { get; set; }
        public string Vector { get; set; }
        public int SortNo { get; set; }
        public string ParentId { get; set; }
        public string Code { get; set; }
        public bool IsSys { get; set; }
    }
}
