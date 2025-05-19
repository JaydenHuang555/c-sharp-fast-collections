using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFastLib.collection.entryutil
{
    public class DoubleEntry<T1, T2> : Entry<T1>
    {

        public T1? First { get => Item; }
        public T2? Second;

        public DoubleEntry(T1? first, T2? second) : base(first) => Second = second;

    }
}
