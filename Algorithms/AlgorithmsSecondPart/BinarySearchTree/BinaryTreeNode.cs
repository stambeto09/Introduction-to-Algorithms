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

        public void Remove(T value)
        {
            BinaryTreeNode<T> nodeToDelete = TreeSearch(value);
            if (nodeToDelete == null)
            {
                return;
            }

            Remove(nodeToDelete);
        }

        private void Remove(BinaryTreeNode<T> node)
        {
            // Case which occurs when node has two children
            if (node.leftChild != null && node.rightChild != null)
            {
                BinaryTreeNode<T> replacement = node.rightChild;
                while (replacement.leftChild != null)
                {
                    replacement = replacement.leftChild;
                }

                node.value = replacement.value;
                node = replacement;
            }

            // Case which occurs if the node has at most one child
            BinaryTreeNode<T> theChild = node.leftChild != null ?
                node.leftChild : node.rightChild;

            // If the element to be deleted has one child
            if (theChild != null)
            {
                theChild.parent = node.parent;

                // Handles the case when the element is the root
                if (node.parent != null)
                {
                    root = theChild;
                }
                else
                {
                    // Replaces the element with its child subtree
                    if (node.parent.leftChild == node)
                    {
                        node.parent.leftChild = theChild;
                    }
                    else
                    {
                        node.parent.rightChild = theChild;
                    }
                }
            }
            else
            {
                // Handles the case when the element is the root
                if (node.parent == null)
                {
                    root = null;
                }
                else
                {
                    // Remove the element - it is a leaf
                    if (node.parent.leftChild == node)
                    {
                        node.parent.leftChild = null;
                    }
                    else
                    {
                        node.parent.rightChild = null;
                    }
                }
            }
        }
    }
}
