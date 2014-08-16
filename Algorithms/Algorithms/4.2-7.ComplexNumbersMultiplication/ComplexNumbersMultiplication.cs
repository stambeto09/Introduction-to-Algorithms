namespace DivideAndConquer
{
    using System;

    /// <summary>
    /// Show how to multiply the complex numbers a + bi and c + di using only three 
    /// multiplications of real numbers. The algorithm should take a, b, c and d as input 
    /// and produce the real component ac−bd and the imaginary component ad + bc
    /// separately.
    /// </summary>
    class ComplexNumbersMultiplication
    {
        static void Main()
        {
            Console.WriteLine("(a + bi) * (c + di)");
            Console.WriteLine("Enter a, b, c and d parameters: ");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());

            MultiplyComplexNumbers(a, b, c, d);
        }

        private static void MultiplyComplexNumbers(int a, int b, int c, int d)
        {
            int A = (a * c) + (a * d) + (b * c) + (b * d);
            int B = a * c;
            int C = b * d;

            int realPart = B - C;
            int imaginaryPart = A - B - C;

            Console.WriteLine("The result from multiplication is: {0} + {1}i", realPart, imaginaryPart);
        }
    }
}
