namespace DesigningAglorithms
{
    using System;

    public class RecursiveMergeSort
    {
        static void Main()
        {
            int[] array = { 9, 5, 3, 10, 6, 15, 2, 13 };
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
                //MergeWithSentilens(array, startIndex, middleIndex, endIndex);
            }
        }

        private static void MergeWithSentilens(int[] array, int startIndex, int middleIndex, int endIndex)
        {
            int leftLength = middleIndex - startIndex + 1;
            int rightLength = endIndex - middleIndex;
            int[] leftArray = new int[leftLength + 1];
            int[] rightArray = new int[rightLength + 1];

            rightArray[rightLength] = int.MaxValue;
            leftArray[leftLength] = int.MaxValue;

            for (int index = 0; index <= leftArray.Length - 2; index++)
            {
                leftArray[index] = array[startIndex + index];
                rightArray[index] = array[middleIndex + index + 1];
            }

            int leftIndex = 0;
            int rightIndex = 0;

            for (int index = startIndex; index <= endIndex; index++)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    array[index] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[index] = rightArray[rightIndex];
                    rightIndex++;
                }
            }
        }

        public static void Merge(int[] array, int startIndex, int middleIndex, int endIndex)
        {
            int[] currentArray = new int[endIndex - startIndex + 1];
            int leftIndex = startIndex;
            int rightIndex = middleIndex + 1;
            int index = 0;

            while (leftIndex <= middleIndex && rightIndex <= endIndex)
            {
                if (array[leftIndex] < array[rightIndex])
                {
                    currentArray[index] = array[leftIndex];
                    index++;
                    leftIndex++;
                }
                else
                {
                    currentArray[index] = array[rightIndex];
                    index++;
                    rightIndex++;
                }
            }

            while (leftIndex <= middleIndex)
            {
                currentArray[index] = array[leftIndex];
                index++;
                leftIndex++;
            }

            while (rightIndex <= endIndex)
            {
                currentArray[index] = array[rightIndex];
                index++;
                rightIndex++;
            }

            index = 0;
            leftIndex = startIndex;
            while (index < currentArray.Length && leftIndex <= endIndex)
            {
                array[leftIndex] = currentArray[index];
                leftIndex++;
                index++;
            }
        }
    }
}