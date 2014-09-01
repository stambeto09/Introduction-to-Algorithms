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
            queue.Add(10);
            queue.Add(15);
            queue.Add(25);
            queue.Add(345);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
