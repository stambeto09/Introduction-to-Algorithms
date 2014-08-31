using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    class Tree<T>
    {
        public Tree(List<Node<T>> nodes)
        {
            this.Nodes = nodes;
        }

        public List<Node<T>> Nodes { get; set; }

    }
}
