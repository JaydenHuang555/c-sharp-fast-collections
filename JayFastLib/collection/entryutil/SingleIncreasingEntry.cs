using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFastLib.collection.entryutil
{
    public class SingleIncreasingEntry<T> : Entry<T>
    {

        public SingleIncreasingEntry<T>? Next;

        public SingleIncreasingEntry(T? item) : base(item) {}
    }
}
