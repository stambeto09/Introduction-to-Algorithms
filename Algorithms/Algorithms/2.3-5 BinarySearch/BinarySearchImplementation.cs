namespace DesigningAlgortihms
{
    using System;

    /// <summary>
    /// Referring back to the searching problem, observe that if the
    /// sequence A is sorted, we can check the midpoint of the sequence against V and
    /// eliminate half of the sequence from further consideration. The binary search al-
    /// gorithm repeats this procedure, halving the size of the remaining portion of the
    /// sequence each time. Write pseudocode, either iterative or recursive, for binary
    /// search. Argue that the worst-case running time of binary search is θ(n*lg n).
    /// </summary>
    class RecursiveBinarySearch
    {
        static void Main()
        {
            int[] numbers = { 79, 57, 97, 46, 66, 57, 84, 11, 22, 53, 71, 36, 97, 5, 26, 54, 
                               30, 90, 65, 9, 84, 37, 37, 73, 46, 30, 78, 49, 87, 59, 1 };
            int minIndex = 0;
            int maxIndex = numbers.Length - 1;
            int key = 97;

            // In order to use Binary search, we have to sort our array.
            Array.Sort(numbers);
            if ((numbers[minIndex] > key) || (numbers[maxIndex] < key))
            {
                Console.WriteLine("The key is not in the sequence of numbers.");
            }
            else
            {
                int result = BinarySearch(numbers, key, minIndex, maxIndex);
                Console.WriteLine("The key is at position: {0}", result);
            }
        }

        public static int BinarySearch(int[] array, int key, int minIndex, int maxIndex)
        {
            int middleIndex = (minIndex + maxIndex) / 2;
            if (array[middleIndex] > key)
            {
                return BinarySearch(array, key, minIndex, middleIndex - 1);
            }
            else if (array[middleIndex] < key)
            {
                return BinarySearch(array, key, middleIndex + 1, maxIndex);
            }
            else
            {
                return middleIndex;
            }
        }
    }
}
