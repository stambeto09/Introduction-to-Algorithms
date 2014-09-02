namespace PriorityQueue
{
    using System.Collections.Generic;

    public class Tree
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
