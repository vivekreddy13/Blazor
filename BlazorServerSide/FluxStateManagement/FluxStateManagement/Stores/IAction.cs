﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxStateManagement.Stores
{
    public interface IAction
    {
        public string Name { get; }
    }
}
