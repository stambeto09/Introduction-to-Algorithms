namespace RodCutting
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] prices = new int[] { 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };
            int length = 4;
            int maximalRevenue = CutRod(prices, length);
            Console.WriteLine("The maximal revenue is: " + maximalRevenue);

            int maxAuxRev = MemoizedCutRod(prices, length);
            Console.WriteLine("The maximal revenue with auxiliary array is: " + maxAuxRev);
        }

        private static int CutRod(int[] prices, int length)
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

        private static int MemoizedCutRod(int[] prices, int length)
        {
            int[] revenues = new int[length + 1];
            for (int index = 0; index < revenues.Length; index++)
            {
                revenues[index] = Int32.MinValue;
            }

            return MemoizedCutRodAux(prices, length, revenues);

        }

        private static int MemoizedCutRodAux(int[] prices, int length, int[] revenues)
        {
            if (revenues[length] >= 0)
            {
                return revenues[length];
            }

            int revenue;

            if (length == 0)
            {
                revenue = 0;
            }
            else
            {
                revenue = int.MinValue;
                for (int index = 0; index < length; index++)
                {
                    revenue = Math.Max(revenue, prices[index] + MemoizedCutRodAux(prices, length - index - 1, revenues));
                }
            }

            revenues[length] = revenue;
            return revenue;
        }
    }
}
