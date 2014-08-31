namespace PriorityQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class PriorityQueue<T> where T : IComparable<T>
    {
        private Tree tree;

        public PriorityQueue()
        {
            this.tree = new Tree(new List<Node<int>>());
        }
        public PriorityQueue(Tree tree)
        {
            this.tree = tree;
        }

        public void Add(T value)
        {
            throw new NotImplementedException();
        }

        public void Maximum()
        {
            throw new NotImplementedException();
        }

        public void ExtractMaxValue()
        {
            throw new NotImplementedException();
        }

        public void IncreaseKey(int index, T key)
        {
            throw new NotImplementedException();
        }
    }
}
