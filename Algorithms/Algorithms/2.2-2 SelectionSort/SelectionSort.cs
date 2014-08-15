namespace AnalyzingAlgorithms
{
    using System;

    /// <summary>
    /// Consider sorting n numbers stored in array A by first finding the smallest element of A
    /// and exchanging it with the element in A[1]. Then find the second smallest
    /// element of A, and exchange it with A[2]. Continue in this manner for the first n - 1
    /// elements of A. Write pseudocode for this algorithm, which is known as selection
    /// sort. What loop invariant does this algorithm maintain? Why does it need to run
    /// for only n - 1 elements, rather than for all n elements? Give the best - case
    /// and worst-case running times for selection sort in Θ-notation.
    /// </summary>
    class SelectionSort
    {
        static void Main()
        {
            int[] array = { 5, 3, 6, 2, 9, 7 };

            int smallestNumber = int.MaxValue;
            int smallestIndex = 0;

            for (int index = 0; index <= array.Length - 2; index++)
            {
                for (int j = index; j <= array.Length - 1; j++)
                {
                    if (array[j] < smallestNumber)
                    {
                        smallestNumber = array[j];
                        smallestIndex = j;
                    }
                }

                array[smallestIndex] = array[index];
                array[index] = smallestNumber;
                smallestNumber = int.MaxValue;
            }

            for (int index = 0; index <= array.Length - 1; index++)
            {
                Console.WriteLine(array[index]);
            }
        }
    }
}