namespace Heapsort
{
    using System;

    class Heapsort
    {
        static void Main()
        {
            int[] array = new int[] { 5, 3, 17, 10, 84, 19, 6, 22, 9 };
            BuildMaxHeap(array);
            Sort(array);

            for (int index = 0; index <= array.Length - 1; index++)
            {
                Console.WriteLine(array[index]);
            }
        }

        private static void Sort(int[] array)
        {
            int heapSize = array.Length;
            for (int index = array.Length - 1; index > 0; index--)
            {
                int thirdVariable = array[index];
                array[index] = array[0];
                array[0] = thirdVariable;

                heapSize--;
                MaxHeapify(array, heapSize, 0);
            }
        }

        private static void BuildMaxHeap(int[] array)
        {
            int heapSize = array.Length;
            for (int index = array.Length / 2; index >= 0; index--)
            {
                MaxHeapify(array, heapSize, index);
            }
        }

        private static void MaxHeapify(int[] array, int heapSize, int index)
        {
            int leftIndex = Left(index);
            int rightIndex = Right(index);
            int largest = 0;

            if (leftIndex < heapSize && array[leftIndex] > array[index])
            {
                largest = leftIndex;
            }
            else
            {
                largest = index;
            }

            if (rightIndex < heapSize && array[rightIndex] > array[largest])
            {
                largest = rightIndex;
            }

            if (largest != index)
            {
                int thirdVariable = 0;
                thirdVariable = array[index];
                array[index] = array[largest];
                array[largest] = thirdVariable;

                MaxHeapify(array, heapSize, largest);
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