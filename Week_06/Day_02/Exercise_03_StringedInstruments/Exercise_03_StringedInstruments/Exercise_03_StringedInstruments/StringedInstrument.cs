﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03_StringedInstruments
{
    abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;
        abstract public void Sound();

    }
}
