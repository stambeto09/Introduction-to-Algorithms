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
            Tree<int> tree = new Tree<int>(new List<Node<int>>());
            PriorityQueue<int> queue = new PriorityQueue<int>();
            queue.Add(5);
            queue.Add(15);
            queue.Add(25);

            foreach (var value in queue)
            {
                Console.WriteLine(value);
            }


        }
    }
}
