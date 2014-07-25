namespace AlgorithmsAsATechnology
{
    using System;
    /// <summary>
    /// What is th smallest value of n such that an algorithm whose running time is 100*n^2
    /// runs faster than an algorithm whose running time is 2^n on the same machine?
    /// </summary>
    class SmallestValue
    {
        static void Main()
        {
            int number = 1;
            double firstAlgorithm = 100 * Math.Pow(number, 2);
            double secondAlgorithm = Math.Pow(2, number);

            while (secondAlgorithm < firstAlgorithm)
            {
                number++;
                firstAlgorithm = 100 * Math.Pow(number, 2);
                secondAlgorithm = Math.Pow(2, number);
            }
            Console.WriteLine("The smallest number is equal to {0}.", number);
        }
    }
}
