namespace PriorityQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Node<T> where T : IComparable<T>
    {
        public T Value { get; set; }

        public Node()
        {

        }

        public Node(T value)
            : this()
        {
            this.Value = value;
        }
    }
}
