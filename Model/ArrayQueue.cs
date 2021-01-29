using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Model
{
    class ArrayQueue<T>
    {
        T[] items;

        private T Head => items[count];
        private T Tail => items[0];

        private int count = -1;
        private int size = 10;

        public ArrayQueue(int Size)
        {
            size = Size;
            items = new T[size];
        }

        public ArrayQueue(int Size, T Data)
        {
            count++;
            size = Size;
            items = new T[size];
            items[0] = Data;
        }
        public void Enqueue(T data)
        {
            if(count < size)
            {
                var tempItems = (new T[] { data }).Concat(items);
                items = tempItems.ToArray();
                count++;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Queue is overflow");
            }
        }

        public T Dequeue()
        {
            if (count != -1)
            {
                T item = Head;
                count--;
                return item;
            }
            else throw new ArgumentOutOfRangeException("Queue is empty.");
        }

        public T Peek()
        {
            return Head;
        }
    }
}
