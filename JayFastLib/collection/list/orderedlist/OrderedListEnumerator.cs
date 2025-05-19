using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFastLib.collection.list.orderedlist
{
    public class OrderedListEnumerator<T> : IEnumerator<T> 
    {
        public readonly OrderedList<T> Buffed;
        private int _off = 0;

        public OrderedListEnumerator(OrderedList<T> list)
        {
            this.Buffed = list;
        }

        public T Current => Buffed[_off];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return _off++ < Buffed.Count;
        }

        public void Reset()
        {
            _off = 0;
        }
    }
}
