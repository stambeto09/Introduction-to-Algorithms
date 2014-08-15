namespace DivideAndConquer
{
    using System;

    class StrassenMatrixMultiplication
    {
        static void Main()
        {
            int[,] firstMatrix = new int[2, 2];
            int[,] secondMatrix = new int[2, 2];

            firstMatrix[0, 0] = 1;
            firstMatrix[0, 1] = 3;
            firstMatrix[1, 0] = 7;
            firstMatrix[1, 1] = 5;

            secondMatrix[0, 0] = 6;
            secondMatrix[0, 1] = 8;
            secondMatrix[1, 0] = 4;
            secondMatrix[1, 1] = 2;

            int[,] result = SquareMatrixMultiply(firstMatrix, secondMatrix);

            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    Console.Write(result[row, col] + "  ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] SquareMatrixMultiply(int[,] firstMatrix, int[,] secondMatrix)
        {
            int n = firstMatrix.GetLength(0);
            int[,] result = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    result[row, col] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        result[row, col] = result[row, col] + (firstMatrix[row, k] * secondMatrix[k, col]);
                    }
                }
            }

            return result;
        }
    }
}