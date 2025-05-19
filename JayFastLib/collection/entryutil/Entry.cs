using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFastLib.collection.entryutil
{
    public class Entry<T>
    {

        public T? Item;

        public Entry(T? item)
        {
            Item = item;
        }

    }
}
