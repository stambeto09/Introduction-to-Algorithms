namespace HeapsortUsingTree
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 };
            List<Node<int>> nodes = new List<Node<int>>();
            foreach (var value in array)
            {
                nodes.Add(new Node<int>(value));
            }

            Tree tree = new Tree(nodes);
            tree.Heapsort();

            foreach (var node in tree.SortedNodes)
            {
                Console.WriteLine(node.Value);
            }

            Console.WriteLine("Heapsize: {0}", tree.HeapSize);
        }
    }
}
