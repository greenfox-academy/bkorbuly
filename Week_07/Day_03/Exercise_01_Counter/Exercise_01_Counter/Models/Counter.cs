﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_01_Counter.Models
{
    public class Counter
    {
        public int Number { get; set; } = 1;

        public void RaiseCounter()
        {
            Number++;
        }
    }

}
