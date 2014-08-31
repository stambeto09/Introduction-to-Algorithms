namespace HeapsortUsingTree
{
    using System.Collections.Generic;
    using System.Linq;

    public class Tree
    {
        public List<Node<int>> Nodes { get; set; }

        public Stack<Node<int>> SortedNodes { get; set; }

        public Tree()
        {
            this.Nodes = new List<Node<int>>();
            this.SortedNodes = new Stack<Node<int>>();
        }
        public Tree(List<Node<int>> nodes)
        {
            this.Nodes = nodes;
            this.SortedNodes = new Stack<Node<int>>();
        }

        public int HeapSize
        {
            get
            {
                return this.Nodes.Count();
            }
        }

        public void Heapsort()
        {
            this.BuildMaxHeap();
            for (int index = this.HeapSize - 1; index > 0; index--)
            {
                int thirdVariable = this.Nodes[index].Value;
                this.Nodes[index].Value = this.Nodes[0].Value;
                this.Nodes[0].Value = thirdVariable;

                this.SortedNodes.Push(this.Nodes[index]);
                this.Nodes.RemoveAt(this.HeapSize - 1);
                this.MaxHeapify(this.Nodes, 0);
            }

            this.SortedNodes.Push(this.Nodes[0]);
            this.Nodes.RemoveAt(0);
        }

        public void BuildMaxHeap()
        {
            for (int index = this.HeapSize / 2; index >= 0; index--)
            {
                MaxHeapify(this.Nodes, index);
            }
        }

        public void MaxHeapify(List<Node<int>> nodes, int index)
        {
            int leftIndex = Left(index);
            int rightIndex = Right(index);
            int largest = 0;

            if (leftIndex < this.HeapSize && nodes[leftIndex].Value > nodes[index].Value)
            {
                largest = leftIndex;
            }
            else
            {
                largest = index;
            }

            if (rightIndex < this.HeapSize && nodes[rightIndex].Value > nodes[largest].Value)
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
    }
}
