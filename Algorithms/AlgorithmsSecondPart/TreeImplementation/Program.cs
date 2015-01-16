namespace TreeImplementation
{
    using System;

    class Program
    {
        static void Main()
        {
            Tree<int> tree =
                new Tree<int>(10, 1,
                    new Tree<int>(11, 2,
                        new Tree<int>(14, 5),
                        new Tree<int>(15, 6)),
                    new Tree<int>(12, 3,
                        new Tree<int>(16, 7),
                        new Tree<int>(17, 8)),
                    new Tree<int>(13, 4,
                        new Tree<int>(18, 9),
                        new Tree<int>(19, 10)));

            tree.PrintDFS();

            tree.PrintLeafs();

            tree.SwapValuesByIndices(3, 8);

            Console.WriteLine("Swapping");

            tree.PrintDFS();
        }
    }
}
