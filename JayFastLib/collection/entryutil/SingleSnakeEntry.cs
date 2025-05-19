using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFastLib.collection.entryutil
{
    public class SingleSnakeEntry<T> : Entry<T> 
    {

        public SingleSnakeEntry<T>? Prev, Next;
        public T Item;

        public SingleSnakeEntry(T? item) : base(item);
        {
        }

    }
}
