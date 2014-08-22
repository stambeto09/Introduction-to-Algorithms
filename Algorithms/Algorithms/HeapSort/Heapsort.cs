namespace Heapsort
{
    using System;

    class Heapsort
    {
        static void Main()
        {
            int[] array = new int[] { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 };
            BuildMaxHeap(array);

            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
        }

        private static void BuildMaxHeap(int[] array)
        {
            for (int index = array.Length / 2; index >= 0; index--)
            {
                MaxHeapify(array, index);
            }
        }

        private static void MaxHeapify(int[] array, int index)
        {
            int leftIndex = Left(index);
            int rightIndex = Right(index);
            int largest = 0;

            if (leftIndex <= array.Length - 1 && array[leftIndex] > array[index])
            {
                largest = leftIndex;                
            }
            else
            {
                largest = index;
            }

            if (rightIndex <= array.Length - 1 && array[rightIndex] > array[largest])
            {
                largest = rightIndex;
            }

            if (largest != index)
            {
                int thirdVariable = 0;
                thirdVariable = array[index];
                array[index] = array[largest];
                array[largest] = thirdVariable;

                MaxHeapify(array, largest);
            }
        }

        private static int Parent(int index)
        {
            return index / 2;
        }
        private static int Left(int index)
        {
            return 2 * index + 1;
        }

        private static int Right(int index)
        {
            return (index + 1) * 2;
        }
    }
}
