
using System.Collections;
using System.Runtime.InteropServices;

namespace JayFastLib.collection.list.orderedlist
{
    unsafe public class OrderedList<T> : IList<T> where T : unmanaged
    {
        T IList<T>.this[int index] { get => _buffer[index]; set => _buffer[index] = value; }

        int IList<T>.Count { get => _count; set => _count = value; }

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
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if(!_disposed)
            {
                if (_buffer != null) Marshal.FreeHGlobal((IntPtr)_buffer);
                GC.SuppressFinalize(this);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}