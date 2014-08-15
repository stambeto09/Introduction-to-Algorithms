namespace DesigningAlgorithms
{
    using System;
    
    /// <summary>
    /// Describe a θ(n lgn)-time algorith that, given a set S of n integers and another
    /// integer x, determines whether or not there exist two elements with S whose sum is
    /// exactly x.
    /// </summary>
    class SumOfTwoIntegersInArray
    {
        static void Main()
        {
            int[] array = { 1, 5, 3, 13, 12, 9, 7 };
            int expectedSum = 0;
            Array.Sort(array);

            bool result = CheckForSum(array, expectedSum);
            Console.WriteLine("Are there two numbers with sum {0}? - {1}", expectedSum, result);
        }

        static bool CheckForSum(int[] array, int expectedSum)
        {
            int startIndex = 0;

            for (int index = 0; index <= array.Length - 1; index++)
            {
                int searchedElement = expectedSum - array[index];
                if (array[startIndex] > searchedElement || array[array.Length - 1] < searchedElement)
                {
                    return false;
                }

                if (BinarySearch(array, searchedElement, startIndex, array.Length - 1) == true)
                {
                    return true;
                }
            }
            return false;
        }

        static bool BinarySearch(int[] array, int searchedElement, int startIndex, int endIndex)
        {
            int middlePoint = (startIndex + endIndex) / 2;

            if (array[middlePoint] > searchedElement)
            {
                BinarySearch(array, searchedElement, startIndex, middlePoint - 1);
            }
            else if (array[middlePoint] < searchedElement)
            {
                return BinarySearch(array, searchedElement, middlePoint + 1, endIndex);
            }
            else if (array[middlePoint] == searchedElement)
            {
                return true;
            }

            return false;
        }
    }
}
