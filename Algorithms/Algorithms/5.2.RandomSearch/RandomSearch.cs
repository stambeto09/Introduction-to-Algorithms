namespace RandomizedAlgorithms
{
    using System;

    /// <summary>
    /// Consider the following randomized strategy: pick a random index i into A. If
    /// A[i] = x, then we terminate; otherwise, we continue the search by picking a new
    /// random index int A. We continue picking random indices into A until we find an
    /// index j such that A[j] = x or until we have checked every element of A. Note
    /// that we pick from the whole set of indices each time, so that we may examine a
    /// given element more than once.
    /// Write a pseudocode for a procedure RAMNDOM-SEARCH to implement the stra-
    /// tegy above. Be sure that your algorithm terminates when all indices into A have
    /// been picked.
    /// </summary>
    class RandomSearch
    {
        static void Main()
        {
            int[] array = new int[] { 3, 6, 2, 5, 8, 10 };
            bool[] visitedIndices = new bool[array.Length];

            for (int index = 0; index <= visitedIndices.Length - 1; index++)
            {
                visitedIndices[index] = false;
            }

            bool isNotFound = true;
            bool areAllVisited = false;
            Random randomValueForIndex = new Random();
            int randomIndex = 0;
            int tries = 0;
            int upperBound = array.Length;
            int searchedValue = 3;

            while (isNotFound && !areAllVisited)
            {
                tries++;
                randomIndex = randomValueForIndex.Next(0, upperBound);
                if (array[randomIndex] == searchedValue)
                {
                    isNotFound = false;
                }
                else
                {
                    visitedIndices[randomIndex] = true;
                    areAllVisited = true;
                    for (int index = 0; index <= array.Length - 1; index++)
                    {
                        areAllVisited &= visitedIndices[index];
                    }
                    if (areAllVisited)
                    {
                        isNotFound = true;
                    }
                }
            }

            if (isNotFound)
            {
                Console.WriteLine("The number has not been found.");
            }
            else
            {
                Console.WriteLine("The number has been found at position {0} with {1} try/tries", randomIndex, tries);
            }
        }
    }
}
