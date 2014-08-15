namespace GettingStarted
{
    using System;
    /// <summary>
    /// Consider the searching problem:
    /// Input: A sequence of n numbers A = {a1, a2,..., an} and a value v.
    /// Output: An index i such that v = A[i] or the special value NIL if v does not appear in A.
    /// Write pseudocode for linear search, which scans through the sequence, looking for v. Using loop invariant,
    /// prove that your algorithm is correct. Make sure that your loop invariant fulfills the three
    /// necessary properties.
    /// </summary>
    class SearchingProblem
    {
        static void Main()
        {
            int[] array = { 2, 10, 15, 3, 7, 14, 5, 9, 6 };
            int value = 7;
            Console.WriteLine("The element is at position: {0}", LinearSearch(array, value));
        }

        public static string LinearSearch(int[] array, int value)
        {
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == value)
                {
                    return index.ToString();
                }
            }
            return "NIL";
        }
    }
}
