using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    class Program
    {
        static void Main()
        {
            PriorityQueue<int> queue = new PriorityQueue<int>();
            queue.Insert(5);
            queue.Insert(10);
            queue.Insert(5);
            queue.Insert(15);
            queue.Insert(25);
            queue.Insert(345);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Increased key");
            queue.IncreaseKey(0, 35);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Insert(1000);
            Console.WriteLine("Maximum: {0}", queue.Maximum());

            Console.WriteLine(queue.ToString());

        }
    }
}
