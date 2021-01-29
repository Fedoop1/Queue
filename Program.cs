using Queue.Model;
using System;


namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> Easy Queue <<<");

            EasyQueue<int> easyQueue = new EasyQueue<int>();

            easyQueue.Enqueue(1);
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            easyQueue.Enqueue(4);
            easyQueue.Enqueue(5);

            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Peek());

            Console.ReadLine();

            Console.WriteLine(">>> Array Queue <<<");

            ArrayQueue<string> arrayQueue = new ArrayQueue<string>(3);

            arrayQueue.Enqueue("Никита");
            arrayQueue.Enqueue("Вика");
            arrayQueue.Enqueue("Алексей");

            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());

            Console.ReadLine();

            Console.WriteLine(">>> Linked Queue <<<");

            LinkedQueue<double> linkedQueue = new LinkedQueue<double>();

            linkedQueue.Enqueue(13.0);
            linkedQueue.Enqueue(26.0);
            linkedQueue.Enqueue(39.0);
            linkedQueue.Enqueue(52.0);

            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Dequeue());

            Console.ReadLine();
            Console.WriteLine(">>> Easy Deque <<<");

            EasyDeque<int> easyDeque = new EasyDeque<int>();

            easyDeque.PushFront(1);
            easyDeque.PushFront(2);
            easyDeque.PushFront(3);
            easyDeque.PushFront(4);
            easyDeque.PushFront(5);
            easyDeque.PushFront(6);

            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopBack());
            Console.WriteLine(easyDeque.PopBack());

            Console.ReadLine();
        }   

    }
}
