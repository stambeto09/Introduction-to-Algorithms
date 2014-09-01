using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    class Tree
    {
        public Tree(List<Node<int>> nodes)
        {
            this.Nodes = nodes;
        }

        public List<Node<int>> Nodes { get; set; }

        public int HeapSize 
        { 
            get
            {
                return this.Nodes.Count;
            }
            set
            {
                this.HeapSize = value;
            }
        }

    }
}
