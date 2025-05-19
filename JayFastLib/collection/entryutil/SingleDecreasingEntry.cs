using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFastLib.collection.entryutil
{
    public class SingleDecreasingEntry<T> : Entry<T>
    {

        public SingleDecreasingEntry<T> Prev;

        public SingleDecreasingEntry(T? item) : base(item) {}

    }
}
