namespace DivideAndConquer
{
    using System;
    /// <summary>
    /// An m x n array A of real numbers is Monge array if for all i, j, k and l such
    /// that A[i,j] + A[k,l] lower or equal to A[i, l] + A[k, j].
    /// In other words, whenever we pick two rows and two columns of a Monge array and
    /// consider the four elements at the intersections of the rows and the columns, the sum
    /// of the upper-left and lower-right elements is less that or equal to the sum of the
    /// lower-left and upper-right elements.
    /// </summary>
    class MongeArray
    {
        static void Main()
        {
            int[,] array = new int[,]
            {
                {10, 17, 13, 28, 23},
                {17, 22, 16, 29, 23},
                {24, 28, 22, 34, 24},
                {11, 13, 6, 17, 7},
                {45, 44, 32, 37, 23},
                {36, 33, 19, 21, 6},
                {75, 66, 51, 53, 34}
            };

            bool isMonge = CheckIsMonge(array);

            Console.WriteLine("Is monge: {0}", isMonge);
        }

        private static bool CheckIsMonge(int[,] array)
        {
            bool isMonge = true;

            for (int row = 0; row < array.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < array.GetLength(1) - 1; col++)
                {
                    if ((array[row, col] + array[row + 1, col + 1]) > (array[row + 1, col] + array[row, col + 1]))
                    {
                        isMonge = false;
                        break;
                    }
                }
            }

            return isMonge;
        }
    }
}
