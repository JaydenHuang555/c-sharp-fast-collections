using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using JayFastLib.collection.entryutil;

namespace JayFastLib.collection.stack
{
    unsafe public class Stack<T> : IDisposable
    {

        private UnsafeSingleSnakeEntry<T>* head, tail;

        public bool Disposed { get; private set; }

        public Stack() 
        {
            Disposed = false;
        }

        ~Stack()
        {
            Dispose();
        }

        public void Dispose()
        {
            if(!Disposed)
            {
                UnsafeSingleSnakeEntry<T>* entry = head;
                while(entry != null)
                {
                    if(entry->Next != null)
                    {
                        entry = entry->Next;
                        Marshal.FreeHGlobal((IntPtr)entry->Prev);
                    }
                    else
                    {
                        Marshal.FreeHGlobal((IntPtr)entry);
                    }
                }
                GC.SuppressFinalize(this);
                Disposed = true;
            }
        }

        public void Push(T item)
        {
            UnsafeSingleSnakeEntry<T>* entry = (UnsafeSingleSnakeEntry<T>*)Marshal.AllocHGlobal(sizeof(UnsafeSingleSnakeEntry<T>));
            entry->Item = item;
            if(head == null)
            {
                head = entry;
                tail = entry;
            }
            else if(tail != null)
            {
                tail->Next = entry;
                tail->Next->Prev = entry;
                tail = tail->Next;
            }
        }

        public T Peek()
        {
            if (IsEmpty() || tail == null) throw new SystemException("peeking empty stack");
            return tail->Item;
        }

        public T Pop()
        {
            T lastIn = Peek();
            if(tail == head)
            {
                tail = null;
                head = null;
            }
            else
            {
                if (tail == null) throw new SystemException("SOMETHING WENT WRONG WITH STACK");
                tail = tail->Prev;
                tail->Next = null;
            }
            return lastIn;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

    }
}
