﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Repository.FlowInstance
{
  public  interface IFlowInstanceRepository<T>
    {
        List<T> Index();
    }
}