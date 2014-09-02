namespace _6._5_7.QueueUsingPriorityQueue
{
    using System;

    class Program
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();

            // Enqueue
            queue.Insert(10);
            queue.Insert(15);
            queue.Insert(20);
            queue.Insert(5);
            queue.Insert(30);
            queue.Insert(35);
            queue.Insert(40);
            queue.Insert(45);

            // Dequeue
            queue.ExtractMax();
            queue.ExtractMax();
            Console.WriteLine(queue.ExtractMax());
            Console.WriteLine(queue.ToString());
        }
    }
}
