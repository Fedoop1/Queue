using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Model
{
    class EasyDeque<T>
    {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();
        int count => items.Count();
        
        public void PushBack(T Data)
        {
            items.Insert(0, Data);
        }
        public void PushFront(T Data)
        {
            items.Add(Data);
        }
        public T PopFront()
        {
            if (count >= 1)
            {
                var item = Head;
                items.Remove(Head);
                return item;
            }   
            else throw new ArgumentOutOfRangeException("Deque is empty");
            
        }
        public T PopBack()
        {
            if (count >= 1)
            {
                var item = Tail;
                items.Remove(Tail);
                return item;
            }
            else throw new ArgumentOutOfRangeException("Deque is empty");
        }

        public T PeekBack()
        {
            return Tail;
        }

        public T PeekFront()
        {
            return Head;
        }

    }
}
