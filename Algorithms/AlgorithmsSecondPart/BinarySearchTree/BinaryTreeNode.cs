namespace BinarySearchTree
{
    using System;

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>>
            where T : IComparable<T>
        {
            internal T value;
            internal BinaryTreeNode<T> parent;
            internal BinaryTreeNode<T> leftChild;
            internal BinaryTreeNode<T> rightChild;

            public BinaryTreeNode(T value)
            {
                this.value = value;
                this.parent = null;
                this.rightChild = null;
                this.leftChild = null;
            }

            public override string ToString()
            {
                return this.value.ToString();
            }

            public override int GetHashCode()
            {
                return this.value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                BinaryTreeNode<T> other = (BinaryTreeNode<T>)obj;
                return this.CompareTo(other) == 0;
            }

            public int CompareTo(BinaryTreeNode<T> other)
            {
                return this.value.CompareTo(other.value);
            }
        }

        private BinaryTreeNode<T> root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Insert(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.root = Insert(value, null, root);
        }

        private BinaryTreeNode<T> Insert(T value,
            BinaryTreeNode<T> parentNode,
            BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                node = new BinaryTreeNode<T>(value);
                node.parent = parentNode;
            }
            else
            {
                int compareTo = value.CompareTo(node.value);
                if (compareTo < 0)
                {
                    node.leftChild = Insert(value, node, node.leftChild);
                }
                else if (compareTo > 0)
                {
                    node.rightChild = Insert(value, node, node.rightChild);
                }
            }

            return node;
        }

        public void Print()
        {
            Print(root);
        }

        private void Print(BinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.value + " ");
            Print(root.leftChild);
            Print(root.rightChild);
        }

        public T TreeMinimum()
        {
            var value = TreeMinimum(root);
            return value;
        }

        private T TreeMinimum(BinaryTreeNode<T> root)
        {
            while (root.leftChild != null)
            {
                root = root.leftChild;
            }

            return root.value;
        }

        public T TreeMaximum()
        {
            var value = TreeMaximum(root);
            return value;
        }

        private T TreeMaximum(BinaryTreeNode<T> root)
        {
            while (root.rightChild != null)
            {
                root = root.rightChild;
            }

            return root.value;
        }

        public BinaryTreeNode<T> TreeSearch(T key)
        {
            return TreeSearch(root, key);
        }

        private BinaryTreeNode<T> TreeSearch(BinaryTreeNode<T> root, T key)
        {
            if (this.root == null || key.CompareTo(root.value) == 0)
            {
                return root;
            }
            if (key.CompareTo(root.value) < 0)
            {
                return TreeSearch(root.leftChild, key);
            }
            else
            {
                return TreeSearch(root.rightChild, key);
            }
        }
    }
}
