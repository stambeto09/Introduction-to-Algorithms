namespace PriorityQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    class PriorityQueue<T> : IEnumerable
    {
        private Tree tree;

        public PriorityQueue()
        {
            this.tree = new Tree(new List<Node<int>>());
        }

        public void Insert(int value)
        {
            int minValue = int.MinValue;
            this.tree.Nodes.Add(new Node<int>(minValue));
            IncreaseKey(this.tree.HeapSize - 1, value);
        }


        /// <summary>
        /// 6.5-8 The operation HEAP-DELETE(A, i) deletes the item in node i from heap A. Give
        /// an implementation of HEAP-DELETE that runs in O(lgn) time for an n-element
        /// max-heap.
        /// </summary>
        /// <param name="index">Holds the index of the element that we are going to delete</param>
        public void Delete(int index)
        {
            if (this.tree.HeapSize <= 0)
            {
                throw new ArgumentException("Heap underflow");
            }

            //MaxHeapify(this.tree.Nodes, 0);
            this.tree.Nodes.RemoveAt(index);
        }

        public int Maximum()
        {
            return this.tree.Nodes[0].Value;
        }

        public int ExtractMax()
        {
            if (this.tree.HeapSize <= 0)
            {
                throw new ArgumentException("Heap underflow");
            }
            int maxValue = this.tree.Nodes[0].Value;
            this.tree.Nodes[0].Value = this.tree.Nodes[this.tree.HeapSize - 1].Value;
            this.tree.Nodes.RemoveAt(0);
            MaxHeapify(this.tree.Nodes, 0);

            return maxValue;
        }

        private void MaxHeapify(List<Node<int>> nodes, int index)
        {
            int leftIndex = Left(index);
            int rightIndex = Right(index);
            int largest = 0;

            if (leftIndex < this.tree.HeapSize && nodes[leftIndex].Value > nodes[index].Value)
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

        public void IncreaseKey(int index, int value)
        {
            this.tree.Nodes[index].Value = value;

            while (index > 0 && this.tree.Nodes[Parent(index)].Value < this.tree.Nodes[index].Value)
            {
                int thirdvalue = this.tree.Nodes[index].Value;
                this.tree.Nodes[index].Value = this.tree.Nodes[Parent(index)].Value;
                this.tree.Nodes[Parent(index)].Value = thirdvalue;
                index = Parent(index);
            }
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

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("Queue result: ");
            while (this.tree.HeapSize != 0)
            {
                output.Append(this.ExtractMax().ToString() + ", ");
            }

            return output.ToString().TrimEnd(new char[] { ',', ' ' });
        }
    }
}
