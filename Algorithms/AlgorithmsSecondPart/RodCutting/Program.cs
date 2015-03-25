namespace RodCutting
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[] { 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };
            int length = 4;

            int maximalRevenue = CutRod(prices, length);
            Console.WriteLine(maximalRevenue);
        }

        public static int CutRod(int[] prices, int length)
        {
            if (length == 0)
            {
                return 0;
            }
            int revenue = Int32.MinValue;
            for (int i = 0; i < length; i++)
            {
                revenue = Math.Max(revenue, prices[i] + CutRod(prices, length - i - 1));
            }

            return revenue;
        }
    }
}
