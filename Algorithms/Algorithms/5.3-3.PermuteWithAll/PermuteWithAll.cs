namespace RandomizedAlgorithms
{
    using System;

    /// <summary>
    /// Suppose that instead of swapping element A[i] with a random element from the
    /// subarray A[i..n], we swapped it with a random element from anywhere in the
    /// array.
    /// </summary>
    class PermuteWithAll
    {
        static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Permute(array);

            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
        }

        private static void Permute(int[] array)
        {
            int upperBound = array.Length - 1;
            int thirdValue = 0;
            Random randomNumber = new Random();
            int randomIndex = 0;

            for (int index = 0; index <= array.Length - 1; index++)
            {
                randomIndex = randomNumber.Next(1, upperBound);
                thirdValue = array[index];
                array[index] = array[randomIndex];
                array[randomIndex] = thirdValue;
            }
        }
    }
}
