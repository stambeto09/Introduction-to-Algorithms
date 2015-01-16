namespace TreeImplementation
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a tree data structure
    /// </summary>
    /// <typeparam name="T">The type of the value in the tree</typeparam>
    public class Tree<T> where T : IComparable
    {
        /// <summary>
        /// Holds the root of the tree
        /// </summary>
        private TreeNode<T> root;

        /// <summary>
        /// Holds the first value which will be used for swapping
        /// </summary>
        private T firstSwapValue;

        /// <summary>
        /// Holds the second value which will be used for swapping
        /// </summary>
        private T secondSwapValue;

        /// <summary>
        /// Holds the number of nodes in the current tree
        /// </summary>
        private int count;

        /// <summary>
        /// Holds the values of the nodes in the array
        /// </summary>
        private T[] array;

        /// <summary>
        /// Constructs the tree
        /// </summary>
        /// <param name="value">Holds the value of the node</param>
        /// <param name="index">Holds the index of the node</param>
        public Tree(T value, int index)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value.");
            }

            this.root = new TreeNode<T>(value);
            this.Root.Index = index;
        }

        /// <summary>
        /// Constructs a tree
        /// </summary>
        /// <param name="value">Holds the value of the node</param>
        /// <param name="index">Holds the index of the current node</param>
        /// <param name="children">Holds a list of array of children of the current node</param>
        public Tree(T value, int index, params Tree<T>[] children)
            : this(value, index)
        {
            foreach (var child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        /// <summary>
        /// Gets the root of the current tree
        /// </summary>
        public TreeNode<T> Root
        {
            get
            {
                return this.root;
            }
        }

        /// <summary>
        /// Traverses and prints tree in Depth First Search (DFS) manner
        /// </summary>
        public void PrintDFS()
        {
            this.PrintDFS(this.root, string.Empty);
        }

        /// <summary>
        /// Swaps value by their indices
        /// </summary>
        /// <param name="firstIndex">Holds the first index</param>
        /// <param name="secondIndex">Holds the second index</param>
        public void SwapValuesByIndices(int firstIndex, int secondIndex)
        {
            this.FindValuesByIndices(this.root, firstIndex, secondIndex);
            this.SwapValues(this.root);
            this.firstSwapValue = default(T);
            this.secondSwapValue = default(T);
        }

        /// <summary>
        /// Searches the values using DFS by first and second index
        /// </summary>
        /// <param name="root">Holds the current root</param>
        /// <param name="firstIndex">Holds the first index</param>
        /// <param name="secondIndex">Holds the second index</param>
        public void FindValuesByIndices(TreeNode<T> root, int firstIndex, int secondIndex)
        {
            if (this.root == null)
            {
                throw new ArgumentNullException("The root cannot be null!");
            }

            if (root.Index == firstIndex)
            {
                this.firstSwapValue = root.Value;
            }

            if (root.Index == secondIndex)
            {
                this.secondSwapValue = root.Value;
            }

            TreeNode<T> child = null;
            for (int index = 0; index < root.ChildrenCount; index++)
            {
                child = root.GetChild(index);
                this.FindValuesByIndices(child, firstIndex, secondIndex);
            }

            // Console.WriteLine("Index: {0} Value 1: {1}", firstIndex, firstSwapValue);
            // Console.WriteLine("Index: {0} Value 2: {1}", secondIndex, secondSwapValue);
            // Console.WriteLine("Current Tree value: {0}", this.Root.Value);
        }

        /// <summary>
        /// Extracts the root of the current tree
        /// </summary>
        /// <returns>Return the current root</returns>
        public T ExtractRoot()
        {
            return this.Root.Value;
        }

        /// <summary>
        /// Prints the leafs of the current tree
        /// </summary>
        public void PrintLeafs()
        {
            this.PrintLeafs(this.root);
        }

        /// <summary>
        /// Counts the number of nodes representing the current tree
        /// </summary>
        /// <returns>Returns the number of nodes</returns>
        public int Count()
        {
            this.count = 0;
            this.Count(this.root);
            return this.count;
        }

        /// <summary>
        /// Extracts current values from nodes to array
        /// </summary>
        /// <returns>Returns the current node's values in array</returns>
        public T[] ToArray()
        {
            this.array = new T[this.Count()];
            this.ToArray(this.root);
            return this.array;
        }

        /// <summary>
        /// Using DFS row through all nodes and search for first and second value to swap them
        /// </summary>
        /// <param name="root">Holds the current node</param>
        private void SwapValues(TreeNode<T> root)
        {
            if (root.Value.CompareTo(this.firstSwapValue) == 0)
            {
                root.Value = this.secondSwapValue;
            }
            else if (root.Value.CompareTo(this.secondSwapValue) == 0)
            {
                root.Value = this.firstSwapValue;
            }

            TreeNode<T> child = null;
            for (int index = 0; index < root.ChildrenCount; index++)
            {
                child = root.GetChild(index);
                this.SwapValues(child);
            }
        }

        /// <summary>
        /// Using DFS row through all nodes and prints them
        /// </summary>
        /// <param name="root">Holds the current node</param>
        /// <param name="spaces">Holds the intervals that will move right with one tabulation the childs of a node</param>
        private void PrintDFS(TreeNode<T> root, string spaces)
        {
            if (this.root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.Value);

            TreeNode<T> child = null;
            for (int index = 0; index < root.ChildrenCount; index++)
            {
                child = root.GetChild(index);
                this.PrintDFS(child, spaces + "  ");
            }
        }

        /// <summary>
        /// Using DFS row through all nodes and prints the leafs
        /// </summary>
        /// <param name="root">Holds the current node</param>
        private void PrintLeafs(TreeNode<T> root)
        {
            if (root.ChildrenCount == 0)
            {
                Console.WriteLine(root.Value);
            }

            TreeNode<T> child = null;
            for (int index = 0; index < root.ChildrenCount; index++)
            {
                child = root.GetChild(index);
                this.PrintLeafs(child);
            }
        }

        /// <summary>
        /// Using DFS row through all nodes and counts them
        /// </summary>
        /// <param name="root">holds the current node</param>
        private void Count(TreeNode<T> root)
        {
            this.count++;
            TreeNode<T> child = null;
            for (int index = 0; index < root.ChildrenCount; index++)
            {
                child = root.GetChild(index);
                this.Count(child);
            }
        }

        /// <summary>
        /// Using DFS row through all nodes and extracts them into array
        /// </summary>
        /// <param name="root">Holds the current root</param>
        private void ToArray(TreeNode<T> root)
        {
            this.array[root.Index - 1] = root.Value;

            TreeNode<T> child = null;
            for (int index = 0; index < root.ChildrenCount; index++)
            {
                child = root.GetChild(index);

                this.ToArray(child);
            }
        }
    }
}
