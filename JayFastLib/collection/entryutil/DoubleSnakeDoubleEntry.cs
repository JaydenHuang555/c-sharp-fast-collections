using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFastLib.collection.entryutil
{
    public class DoubleSnakeDoubleEntry<T1, T2> : DoubleEntry<T1, T2>
    {

        public DoubleSnakeDoubleEntry<T1, T2>? Prev, Next;

        public DoubleSnakeDoubleEntry(T1? first, T2? second) : base(first, second) {}
    }
}
