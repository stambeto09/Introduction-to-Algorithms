namespace GettingStartedProblems
{
    using System;

    /// <summary>
    /// Bubblesort is a popular, but inefficient, sorting algorithm. It works by repeatedly
    /// swapping adjacent elements that are out of order.
    /// </summary>
    class BubbleSort
    {
        static void Main()
        {
            int[] array = { 3, 1, 6, 9, 2 };

            for (int index = 0; index < array.Length - 2; index++)
            {
                for (int j = array.Length - 1; j >= index + 1; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int thirdValue = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = thirdValue;
                    }
                }
            }

            for (int index = 0; index <= array.Length - 1; index++)
            {
                Console.WriteLine(array[index]);
            }
        }
    }
}