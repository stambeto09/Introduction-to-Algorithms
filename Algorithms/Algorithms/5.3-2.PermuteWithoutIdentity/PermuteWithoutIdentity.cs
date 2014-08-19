namespace RandomizedAlgorithms
{
    using System;
    /// <summary>
    /// Professor Kelp decides to write a pseudocode that produces at random any permuta-
    /// tion besides the identity permutation. Does this code do what Professor Kelp intends?
    /// No, it doesn't, the last element is permutating only in one position.
    /// </summary>
    class PermuteWithoutIdentity
    {
        static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Permute(array);

            for (int index = 0; index <= array.Length - 1; index++)
            {
                Console.WriteLine(array[index]);
            }
        }

        private static void Permute(int[] array)
        {
            Random randomNumber = new Random();
            int swapVariable = 0;
            int randomIndex = 0;
            int upperBound = array.Length - 1;

            for (int index = 0; index < array.Length - 1; index++)
            {
                randomIndex = randomNumber.Next(index + 1, upperBound);
                swapVariable = array[randomIndex];
                array[randomIndex] = array[index];
                array[index] = swapVariable;
            }
        }
    }
}
