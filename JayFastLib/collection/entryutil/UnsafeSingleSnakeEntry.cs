using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFastLib.collection.entryutil
{
    unsafe public class UnsafeSingleSnakeEntry<T> : SingleSnakeEntry<T>
    {

        public UnsafeSingleSnakeEntry<T>* Prev, Next;

        public UnsafeSingleSnakeEntry(T? item) : base(item)
        {
        }

        public void Alloc()
        {
            Prev = null;
            Next = null;
        }

    }
}
