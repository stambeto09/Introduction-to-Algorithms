namespace _2._1_2.DescendingInsertionSort
{
    using System;

    /// <summary>
    /// Rewrite the INSERTION-SORT procedure to sort into nonincreasing instead of nondecreasing orded
    /// </summary>
    class DescendingInsertionSort
    {
        static void Main()
        {
            int[] array = { 5, 2, 4, 6, 1, 3 };
            int currentElement = 0;
            int nextIndex = 0;

            for (int index = array.Length - 2; index >= 0; index--)
            {
                currentElement = array[index];
                nextIndex = index + 1;

                while ((nextIndex <= array.Length - 1) && (array[nextIndex] > currentElement))
                {
                    array[nextIndex - 1] = array[nextIndex];
                    nextIndex++;
                }

                array[nextIndex - 1] = currentElement;
            }

            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
        }
    }
}
