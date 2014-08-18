namespace PermuteBySorting
{
    using System;

    /// <summary>
    /// One common method is to asign each element A[i] of the array a random pri-
    /// ority P[i], and the sort the elements of A according to these priorities. For ex-
    /// ample, if our initial array is A = [1, 2, 3, 4] and we choose random priorities
    /// P = [36, 3, 62, 19], we would produce an array B[2, 4, 1, 3]...
    /// </summary>
    class PermuteBySorting
    {
        static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // int[] array = new int[] { 1, 2, 3, 4 };

            Permute(array);

            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
        }

        private static void Permute(int[] array)
        {
            int[] priorities = new int[array.Length];
            Random randomNumber = new Random();

            for (int index = 0; index <= priorities.Length - 1 ; index++)
            {
                priorities[index] = randomNumber.Next(1, priorities.Length * 3);
            }

            int currentPriority = 0;
            int previousIndex = 0;
            int currentElement = 0;

            for (int index = 1; index <= priorities.Length - 1; index++)
            {
                currentPriority = priorities[index];
                previousIndex = index - 1;
                currentElement = array[index];

                while ((previousIndex >= 0) && (priorities[previousIndex] > currentPriority))
                {
                    array[previousIndex + 1] = array[previousIndex];
                    previousIndex--;
                }
                array[previousIndex + 1] = currentElement;
            }
        }
    }
}
