using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JayFastLib.collection.entryutil;

namespace JayFastLib.collection.stack
{
    unsafe public class Stack<T>
    {

        private SingleSnakeEntry<T>? head, tail;

        public Stack() { }

        public void Push(T item)
        {
            SingleSnakeEntry<T> nextEntry = new SingleSnakeEntry<T>(item);
            if(head == null)
            {
                head = nextEntry;
                tail = nextEntry;
            }
            else if(tail != null) // null condition to avoid warning
            {
                tail.Next = nextEntry;
                tail.Next.Prev = tail;
                tail = tail.Next;
            }
        }

        public T Peek()
        {
            if (IsEmpty() || tail == null) throw new SystemException("peeking empty stack");
            return tail.Item;
        }

        public T Pop()
        {
            T firstOut = Peek();
            if(tail == head)
            {
                tail = null;
                head = null;
            }
            else
            {
                if (tail == null) throw new SystemException("SOMETHING WENT WRONG WITH STACK");
                tail = tail.Prev;
                tail.Next = null;
            }
            return firstOut;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

    }
}
