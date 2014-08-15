namespace GettingStarted
{
    using System;
    /// <summary>
    /// Consider the problem of adding two n-bit binary integers, stored in two
    /// n-element array A and B. The sum of the two integers should be stored in binary form in an
    /// (n+1)-element array C. State the problem formally and write pseudocode for adding the two integers.
    /// </summary>
    class AddingTwoBinaryDigits
    {
        static void Main()
        {
            int[] firstNumber = { 1, 1, 0, 0, 1, 0 };
            int[] secondNumber = { 0, 1, 1, 1, 1, 0 };
            int[] resultNumber = new int[firstNumber.Length + 1];
            int carry = 0;

            for (int index = firstNumber.Length - 1; index >= 0; index--)
            {
                resultNumber[index + 1] = (firstNumber[index] + secondNumber[index] + carry) % 2;
                carry = (firstNumber[index] + secondNumber[index] + carry) / 2;
                resultNumber[index] = carry & 1;
            }

            for (int index = 0; index <= resultNumber.Length - 1; index++)
            {
                Console.Write(resultNumber[index]);
            }
            Console.WriteLine();
        }
    }
}
