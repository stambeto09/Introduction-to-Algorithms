namespace BinarySearchTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            BinarySearchTree<int> binaryTree = new BinarySearchTree<int>();

            binaryTree.Insert(10);
            binaryTree.Insert(13);
            binaryTree.Insert(6);
            binaryTree.Insert(2);
            binaryTree.Insert(25);
            binaryTree.Print();

            Console.WriteLine(binaryTree.TreeSearch(6));
        }
    }
}
