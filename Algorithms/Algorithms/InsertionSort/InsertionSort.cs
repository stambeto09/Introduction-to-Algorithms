namespace InsertionSort
{
    using System;
    using System.Diagnostics;

    public class InsertionSort
    {
        static void Main()
        {
            int[] arrayOfHundredRandomNumbers = { 
                            50,	79,	73,	51,	40,
                            46,	45,	82,	69,	96,
                            49,	44,	9,	5,	19,
                            32,	30,	30,	38,	24,
                            46,	71,	78,	7,	85,
                            93,	66,	81,	19,	42,
                            2,	77,	81,	30,	45,
                            36,	25,	96,	99,	17,
                            19,	14,	25,	31,	78,
                            71,	1,	78,	41,	93,
                            73,	64,	36,	15,	2,
                            9,	1,	8,	76,	79,
                            81,	63,	14,	43,	49,
                            14,	73,	90,	97,	2,
                            17,	90,	5,	82,	73,
                            76,	19,	33,	32,	25,
                            12,	48,	41,	82,	92,
                            34,	27,	35,	63,	25,
                            83,	21,	34,	69,	83,
                            65,	21,	7,	39,	5 
                          };

            UseInsertionSort(arrayOfHundredRandomNumbers);
        }

        public static void UseInsertionSort(int[] array)
        {
            int currentElement = 0;
            int previousIndex = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int index = 1; index <= array.Length - 1; index++)
            {
                currentElement = array[index];
                previousIndex = index - 1;

                while ((previousIndex >= 0) && (array[previousIndex] > currentElement))
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

            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0}", stopwatch.Elapsed);
        }
    }
}