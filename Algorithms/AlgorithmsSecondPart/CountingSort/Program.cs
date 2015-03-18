namespace CountingSort
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 6, 0, 2, 0, 1, 3, 4, 6, 1, 3, 2 };

            int[] countingArray = new int[array.Max() + 1];

            int[] sortedArray = new int[array.Length];

            for (int index = 0; index < array.Length; index++)
            {
                countingArray[array[index]]++;
            }

            int j = 0;
            for (int index = 0; index < countingArray.Length; index++)
            {
                while (countingArray[index] > 0)
                {
                    sortedArray[j] = index;
                    j++;
                    countingArray[index]--;
                }
            }

            PrintArray(sortedArray);
        }

        private static void PrintArray(int[] sortedArray)
        {
            for (int index = 0; index < sortedArray.Length; index++)
            {
                Console.WriteLine(sortedArray[index]);
            }
        }
    }
}
