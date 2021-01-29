using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Model
{
    class LinkedQueue<T>
    {
        Item<T> Head;
        Item<T> Tail;
        int count = 0;

        public LinkedQueue()
        {

        }
        public LinkedQueue(T Data)
        {
            setDefault(Data);
        }

        public void setDefault(T Data)
        {
            Item<T> item = new Item<T>(Data);

            Head = item;
            Tail = item;
            count++;
        }

        public void Enqueue(T Data)
        {
            if (count == 0)
            {
                setDefault(Data);
                return;
            }

            var item = new Item<T>(Data);
            item.Next = Tail;
            Tail = item;
            count++;
        }

        public T Dequeue()
        {
            var data = Head.data;

            var current = Tail.Next;
            var previous = Tail;

            while(current != null && current.Next != null)
            {
                previous = current;
                current = current.Next;
            }
            
            Head = previous;
            Head.Next = null;
            count--;
            return data;
        }

        public T Peek()
        {
            return Head.data;
        }
    }
}
