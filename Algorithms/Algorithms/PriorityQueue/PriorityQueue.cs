using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    class PriorityQueue<T> : IEnumerable<T>
    {
        private Tree<T> tree;

        public PriorityQueue()
        {
            this.tree = new Tree<T>(new List<Node<T>>());
        }

        public void Add(T value)
        {
            this.tree.Nodes.Add(new Node<T>(value));
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var node in this.tree.Nodes)
            {
                yield return node.Value;
            }

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
