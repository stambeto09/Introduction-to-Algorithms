namespace RandomizedAlgorithms
{
    using System;

    /// <summary>
    /// Professor Armstrong suggests the following procedure for generating a uniform
    /// random permutation.
    /// Show that each element A[i] has 1/n probability of winding up in any particular
    /// position in B. Then show that Professor Armstrong is mistaken by showing that
    /// the resulting permutation is not uniformly random.
    /// Solution: As we can see, only the first element[place] is randomized and the
    /// other ones are sorted as well as before, and if the index is greater than the
    /// last index of the array, the place becomes 0 or greater but the followed numbers are
    /// still in the same order.
    /// </summary>
    class PermuteByCyclic
    {
        static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] permutedArray = Permute(array);

            for (int index = 0; index <= permutedArray.Length - 1 ; index++)
            {
                Console.WriteLine(permutedArray[index]);
            }
        }

        private static int[] Permute(int[] array)
        {
            int upperBound = array.Length - 1;
            Random randomNumber = new Random();
            int offset = randomNumber.Next(0, upperBound);
            int place = 0;
            int[] result = new int[array.Length];

            for (int index = 0; index <= array.Length - 1 ; index++)
            {
                place = index + offset;
                if (place > upperBound)
                {
                    place = place - upperBound - 1;
                }
                result[place] = array[index];
            }

            return result;
        }
    }
}
