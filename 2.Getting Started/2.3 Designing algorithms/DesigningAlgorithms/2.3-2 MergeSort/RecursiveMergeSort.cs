namespace DesigningAglorithms
{
    using System;

    class RecursiveMergeSort
    {
        static void Main()
        {
            int[] array = { 9, 5, 3, 10, 6, 11, 15, 10};
            int startIndex = 0;
            int endIndex = array.Length - 1;
            MergeSort(array, startIndex, endIndex);

            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
        }

        public static void MergeSort(int[] array, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int middleIndex = (startIndex + endIndex) / 2;
                MergeSort(array, startIndex, middleIndex);
                MergeSort(array, middleIndex + 1, endIndex);
                Merge(array, startIndex, middleIndex, endIndex);
            }
        }

        public static void Merge(int[] array, int startIndex, int middleIndex, int endIndex)
        {
            int[] temp = new int[endIndex - startIndex + 1];
            int leftIndex = startIndex;
            int rightIndex = middleIndex + 1;
            int index = 0;

            while (leftIndex <= middleIndex && rightIndex <= endIndex)
            {
                if (array[leftIndex] < array[rightIndex])
                {
                    temp[index] = array[leftIndex];
                    index++;
                    leftIndex++;
                }
                else
                {
                    temp[index] = array[rightIndex];
                    index++;
                    rightIndex++;
                }
            }

            while (leftIndex <= middleIndex)
            {
                temp[index] = array[leftIndex];
                index++;
                leftIndex++;
            }

            while (rightIndex <= endIndex)
            {
                temp[index] = array[rightIndex];
                index++;
                rightIndex++;
            }

            index = 0;
            leftIndex = startIndex;
            while (index < temp.Length && leftIndex <= endIndex)
            {
                array[leftIndex] = temp[index];
                leftIndex++;
                index++;
            }
        }
    }
}
