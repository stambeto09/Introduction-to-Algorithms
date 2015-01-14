namespace Quicksort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 2, 8, 7, 1, 3, 5, 6, 4 };
            int startIndex = 0;
            int endIndex = array.Length - 1;
            Quicksort(array, startIndex, endIndex);

            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
        }

        private static void Quicksort(int[] array, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int middle = Partition(array, startIndex, endIndex);
                Quicksort(array, startIndex, middle - 1);
                Quicksort(array, middle + 1, endIndex);
            }
        }

        private static int Partition(int[] array, int startIndex, int endIndex)
        {
            int pivot = array[endIndex];
            int i = startIndex - 1;
            int swapVariable = 0;

            for (int index = startIndex; index <= endIndex - 1; index++)
            {
                if (array[index] >= pivot)
                {
                    i++;
                    swapVariable = array[i];
                    array[i] = array[index];
                    array[index] = swapVariable;
                }
            }

            swapVariable = array[i + 1];
            array[i + 1] = array[endIndex];
            array[endIndex] = swapVariable;

            return i + 1;
        }
    }
}
