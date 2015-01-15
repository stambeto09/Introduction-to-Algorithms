namespace TreeImplementation
{
    class Program
    {
        static void Main()
        {
            Tree<int> tree =
                new Tree<int>(10,
                    new Tree<int>(11,
                        new Tree<int>(14),
                        new Tree<int>(15)),
                    new Tree<int>(12,
                        new Tree<int>(16),
                        new Tree<int>(17)),
                    new Tree<int>(13,
                        new Tree<int>(18),
                        new Tree<int>(19)));

            tree.PrintDFS();
        }
    }
}
