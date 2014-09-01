using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    class PriorityQueue<T> : IEnumerable
    {
        private Tree tree;

        public PriorityQueue()
        {
            this.tree = new Tree(new List<Node<int>>());
        }

        public void Add(int value)
        {
            this.tree.Nodes.Add(new Node<int>(value));
        }

        public int Maximum()
        {
            return this.tree.Nodes[0].Value;
        }

        public int ExtractMax()
        {
            int maxValue = this.tree.Nodes[0].Value;
            this.tree.Nodes.RemoveAt(0);
            MaxHeapify(this.tree.Nodes, 0);
            return maxValue;
        }

        private void MaxHeapify(List<Node<int>> nodes, int index)
        {
            int leftIndex = Left(index);
            int rightIndex = Right(index);
            int largest = 0;

            if (leftIndex < this.tree.HeapSize)
            {
                largest = leftIndex;
            }
            else
            {
                largest = index;
            }

            if (rightIndex < this.tree.HeapSize && nodes[rightIndex].Value > nodes[largest].Value)
            {
                largest = rightIndex;
            }

            if (largest != index)
            {
                int thirdVariable = 0;
                thirdVariable = nodes[index].Value;
                nodes[index].Value = nodes[largest].Value;
                nodes[largest].Value = thirdVariable;

                MaxHeapify(nodes, largest);
            }
        }

        public void IncreaseKey()
        {
            throw new NotImplementedException();
        }

        private static int Parent(int index)
        {
            return index / 2;
        }
        private static int Left(int index)
        {
            return 2 * index + 1;
        }

        private static int Right(int index)
        {
            return (index + 1) * 2;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var node in this.tree.Nodes)
            {
                yield return node.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
