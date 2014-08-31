namespace PriorityQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tree
    {
        public Tree()
        {
            
        }

        public Tree(List<Node<int>> nodes)
            : this()
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

            private set
            {
                this.HeapSize = value;
            }
        }
    }
}
