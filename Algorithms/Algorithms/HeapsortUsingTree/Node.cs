namespace HeapsortUsingTree
{
    using System;

    public class Node<T> where T : IComparable<T>
    {
        public T Value { get; set; }

        public Node()
        {

        }

        public Node(T value)
        {
            this.Value = value;
        }
    }
}
