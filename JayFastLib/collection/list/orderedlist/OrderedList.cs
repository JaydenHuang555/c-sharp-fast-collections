
using System.Collections;
using System.Runtime.InteropServices;

namespace JayFastLib.collection.list.orderedlist
{
    unsafe public class OrderedList<T>  : IDisposable, IEnumerable<T>
    {
        public T this[int index] { get => _buffer[index]; set => _buffer[index] = value; }

        public int Count { get; private set; }

        private int _count, _cap;
        private bool _disposed;
        private T* _buffer;

        public OrderedList()
        {
            _cap = 1 << 4;
            _disposed = false;
            _buffer = (T*)Marshal.AllocHGlobal(sizeof(T) * _cap);
        }

        public void Add(T item)
        {
            _buffer[_count++] = item;
            if(_count ==  _cap)
            {
                T *next = (T*)Marshal.AllocHGlobal(sizeof(T) * (_cap * 2));
                for (int i = 0; i < _cap; i++) next[i] = _buffer[i];
                Marshal.FreeHGlobal((IntPtr)_buffer);
                _buffer = next;
            }
        }

        public T Get(int index)
        {
            return _buffer[index]; 
        }

        public void Clear()
        {
            _count = 0;
        }

        public bool Contains(T target)
        {
            for (int i = 0; i < Count; i++)
                if (_buffer[i].Equals(target)) return true;
            return false;
        }

        public void Dispose()
        {
            if(!_disposed)
            {
                if (_buffer != null) Marshal.FreeHGlobal((IntPtr)_buffer);
                GC.SuppressFinalize(this);
            }
        }

        // TODO: IMPLEMENT THESE METHODS

        public IEnumerator<T> GetEnumerator()
        {
            return new OrderedListEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new OrderedListEnumerator<T>(this);
        }

    }
}