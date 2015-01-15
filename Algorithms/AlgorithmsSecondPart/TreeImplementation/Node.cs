namespace TreeImplementation
{
    using System;
    using System.Collections.Generic;

    public class Node<T> : IComparable<Node<T>> where T : IComparable<T>
    {
        public T Data { get; set; }

        public Node<T> Parent { get; set; }

        public ICollection<Node<T>> Children { get; set; }

        public Node(T data, Node<T> parent)
        {
            this.Data = data;
            this.Children = new List<Node<T>>();
        }

        public bool isRoot()
        {
            if (this.Parent == null)
            {
                return true;
            }

            return false;
        }

        public bool isLeaf()
        {
            if (this.Children.Count == 0)
            {
                return true;
            }

            return false;
        }

        public int CompareTo(Node<T> other)
        {
            if (this.Data.CompareTo(other.Data) < 0)
            {
                return -1;
            }
            else if (this.Data.CompareTo(other.Data) > 0)
            {
                return 1;
            }

            return 0;
        }
    }
}
