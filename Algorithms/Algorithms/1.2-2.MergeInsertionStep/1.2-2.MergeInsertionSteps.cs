namespace AlgorithmsAsATechnology
{
    using System;
    /// <summary>
    /// Suppose we are comparing implementation of insertion sort and merge sort
    /// on the same machine. For inputs of size n, insertion sort runs 8*n^2 steps,
    /// while merge sort runs 64lg n steps. For which values of n does insertion sort
    /// beats merge sort?
    /// </summary>
    class InsertionMergeSortStepsProblem
    {
        /// <summary>
        /// It looks like from the result our interval is from 2 including
        /// to 43. We miss the value n = 1 because at that point merge value is
        /// equal to 0;
        /// </summary>
        static void Main()
        {
            int number = 2;
            double mergeValue =8 * Math.Log(number, 10) ;
            double insertionValue = number;

            while (insertionValue < mergeValue)
            {
                number++;
                mergeValue = 8 * Math.Log(number, 2);
                insertionValue = number;
                Console.WriteLine("Insertion value: {0}  Merge value: {1}",
                    insertionValue, mergeValue);
            }
        }
    }
}
