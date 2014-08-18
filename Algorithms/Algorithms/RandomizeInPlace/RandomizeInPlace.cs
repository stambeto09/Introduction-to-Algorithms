namespace RandomizedAlgorithms
{
    using System;

    /// <summary>
    /// A better method for generating a random permutation is to permute the given
    /// array in place. The procedure RANDOMIZE-IN-PLACE does so in O(n) time. In
    /// its ith iteration, it chooses the element A[i] randomly from among elements A[i]
    /// through A[n]. Subsequent to the ith iteration, A[i] is never altered.
    /// </summary>
    class RandomizeInPlace
    {
        static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Randomize(array);

            for (int index = 0; index <= array.Length - 1 ; index++)
            {
                Console.WriteLine(array[index]);
            }
        }

        private static void Randomize(int[] array)
        {
            Random randomNumber = new Random();
            int swapVariable = 0;
            int randomIndex = 0;
            int upperBound = array.Length - 1;

            for (int index = 0; index <= array.Length - 1 ; index++)
            {
                randomIndex = randomNumber.Next(index, upperBound);
                swapVariable = array[randomIndex];
                array[randomIndex] = array[index];
                array[index] = swapVariable;
            }
        }
    }
}
