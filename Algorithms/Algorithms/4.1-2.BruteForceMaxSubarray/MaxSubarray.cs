namespace DivideAndConquer
{
    using System;

    /// <summary>
    /// Write pseudocode for the brute-force method of solving the maximum-subarray
    /// problem. Your procedure should run in θ(n^2).
    /// </summary>
    class MaxSubarray
    {
        static void Main()
        {
            int[] array = new int[] { 13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7 };
            int bestStart = 0;
            int bestEnd = 0;
            int currentSum = 0;
            int bestSum = int.MinValue;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                currentSum = 0;    
                for (int j = i; j <= array.Length - 1; j++)
                {
                    currentSum += array[j];
                    if (currentSum >= bestSum)
                    {
                        bestStart = i;
                        bestSum = currentSum;
                        bestEnd = j;
                    }
                }
            }

            for (int index = bestStart; index <= bestEnd; index++)
            {
                Console.WriteLine(array[index]);
            }
        }
    }
}