using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    class Node<T>
    {
        public Node(int value)
        {
            this.Value = value;
        }

        public int Value { get; set; }

    }
}
