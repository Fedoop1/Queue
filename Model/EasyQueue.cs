using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Model
{
    class EasyQueue<T>
    {
        List<T> items = new List<T>();

        private T Head => items.Last();
        private T Tail => items.First();

        public void Enqueue(T data)
        {
            items.Insert(0, data);
        }

        public T Dequeue()
        {
            if (items.Count >= 1)
            {
                var item = Head;
                items.Remove(item);
                return item;
            }

            else throw new ArgumentNullException("Queue is empty");
        }

        public T Peek()
        {
            return Head;
        }

        public EasyQueue(T data)
        {
            items.Add(data);
        }
        public EasyQueue()
        {

        }
    }
}
