﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co_Contra_Variance
{
    interface IPushable<in T>
    {
        void Push(T a);
    }
}
