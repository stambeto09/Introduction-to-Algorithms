namespace DesigningAlgorithms
{
    using System;

    /// <summary>
    /// We can express insertion sort as a recursive procedure as follows. In order to sort
    /// A[1..n], we recursively sort A[1..n - 1] and then insert A[n] into the sorted array
    /// A[1..n - 1]. Write a recurrence for the running time of this recursive version of
    /// insertion sort.
    /// </summary>
    class RecursiveInsertionSort
    {
        static void Main()
        {
            int[] array = { 2, 10, 6, 3, 8, 1, 5 };
            int index = 1;
            InsertionSort(array, index);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void InsertionSort(int[] array, int index)
        {
            int currentElement = array[index];
            int previousIndex = index - 1;

            while ((previousIndex >= 0) && (array[previousIndex] > currentElement))
            {
                array[previousIndex + 1] = array[previousIndex];
                previousIndex--;
            }
            array[previousIndex + 1] = currentElement;

            if (index < array.Length - 1)
            {
                index++;
                InsertionSort(array, index);
            }
        }
    }
}
