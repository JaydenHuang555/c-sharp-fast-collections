﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFastLib.collection.pair
{
    public class Pair<T1, T2>
    {

        public T1 First { get; set; }
        private T2 Second { get; set; }

        public override string ToString() => "First: "+First+", Second: "+Second;

    }
}
