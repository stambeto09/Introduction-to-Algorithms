namespace RandomizedAlgorithms
{
    using System;

    class RandomHireAssistant
    {
        static void Main()
        {
            int numberOfCandidates = 10;
            int[] candidates = new int[numberOfCandidates];

            Random randomNumber = new Random();
            for (int index = 0; index <= candidates.Length - 1; index++)
            {
                candidates[index] = randomNumber.Next(1, 100);
            }

            RandomizedHireAssistant(candidates);
        }

        private static void RandomizedHireAssistant(int[] candidates)
        {
            int bestCandidate = 0;
            int numberOfHirings = 0;
            for (int index = 0; index <candidates.Length - 1 ; index++)
            {
                if (candidates[index] > bestCandidate)
                {
                    bestCandidate = candidates[index];
                    Console.WriteLine("New best candidate hired.");
                    numberOfHirings++;
                }
            }

            Console.WriteLine("There are {0} untill we find the best one.", numberOfHirings);
        }
    }
}
