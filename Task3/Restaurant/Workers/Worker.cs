﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    abstract class Worker
    {
        private bool isWork = true;
        public bool IsWork { get { return isWork; } protected set { isWork = value; } }

    }
}
