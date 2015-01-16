namespace TreeImplementation
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a tree node
    /// </summary>
    /// <typeparam name="T">The type of the value in the nodes</typeparam>
    public class TreeNode<T> : IComparable<TreeNode<T>> where T : IComparable
    {
        /// <summary>
        /// Keeps the value of the node
        /// </summary>
        private T value;

        /// <summary>
        /// Keeps a boolean that shows if the current node has a parents
        /// </summary>
        private bool hasParent;

        /// <summary>
        /// Keeps the children of the current node in list
        /// </summary>
        private List<TreeNode<T>> children;

        /// <summary>
        /// Keeps the index of the current node
        /// </summary>
        private int index;

        /// <summary>
        /// Initializes a new instance of the TreeNode class
        /// </summary>
        /// <param name="value">Holds the value of the node</param>
        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.value = value;
            this.children = new List<TreeNode<T>>();
        }

        /// <summary>
        /// Gets and sets the index of the current node
        /// </summary>
        public int Index
        {
            get
            {
                return this.index;
            }

            set
            {
                this.index = value;
            }
        }

        /// <summary>
        /// Gets and sets the value of the current node
        /// </summary>
        public T Value
        {
            get
            {
                return this.value;
            }

            set
            {
                this.value = value;
            }
        }

        /// <summary>
        /// Gets the number of children in the current node
        /// </summary>
        public int ChildrenCount
        {
            get
            {
                return this.children.Count;
            }
        }

        /// <summary>
        /// Adds a child in the current node
        /// </summary>
        /// <param name="child">holds the child which will be added</param>
        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            if (child.hasParent)
            {
                throw new ArgumentException("The node already has a parent!");
            }

            child.hasParent = true;
            this.children.Add(child);
        }

        /// <summary>
        /// Returns the child on specified index
        /// </summary>
        /// <param name="index">Holds the index</param>
        /// <returns>Returns the child on the current index</returns>
        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }

        /// <summary>
        /// Compares two objects from type TreeNode"/>
        /// </summary>
        /// <param name="other">Holds the other object</param>
        /// <returns>Returns the result from comparing</returns>
        public int CompareTo(TreeNode<T> other)
        {
            if (this.Value.CompareTo(other.Value) > 0)
            {
                return 1;
            }
            else if (this.Value.CompareTo(other.Value) < 0)
            {
                return -1;
            }

            return 0;
        }
    }
}
