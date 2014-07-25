namespace InsertionSort
{
    using System;
    class InsertionSort
    {
        static void Main()
        {
            int[] array = { 5, 2, 4, 6, 1, 3 };

            int currentElement = 0;
            int previousIndex = 0;
            for (int index = 1; index <= array.Length - 1; index++)
            {
                currentElement = array[index];
                previousIndex = index - 1;

                while (previousIndex >= 0 && array[previousIndex] > currentElement)
                {
                    array[previousIndex + 1] = array[previousIndex];
                    previousIndex--;
                }
                array[previousIndex + 1] = currentElement;
            }

            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
        }
    }
}

