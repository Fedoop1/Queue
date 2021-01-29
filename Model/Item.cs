using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Model
{
    class Item<T>
    {
        public T data { get; set; }
        public Item<T> Next { get; set; }

        public Item(T Data)
        {
            data = Data;
        }
    }
}
