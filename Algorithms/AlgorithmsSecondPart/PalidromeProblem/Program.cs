namespace PalindromeProblem
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] array =
	        {
	            "civic",
	            "deified",
	            "deleveled",
	            "devoved",
	            "dewed",
	            "Hannah",
	            "kayak",
	            "level",
	            "madam",
	            "racecar",
	            "radar",
	            "redder",
	            "refer",    
	            "repaper",
	            "reviver",
	            "rotator",
	            "rotor",
	            "sagas",
	            "solos",
	            "sexes",
	            "stats",
	            "tenet",

	            "Dot",
	            "Net",
	            "Perls",
	            "Is",
	            "Not",
	            "A",
	            "Palindrome",
	            ""
	        };

            foreach (var item in array)
            {
                Console.WriteLine(item + " = " + IsPalindrome(item));
            }

            string word = "rotator";
            Console.WriteLine(CraftedIsPalindrome(word));
        }

        private static bool IsPalindrome(string word)
        {
            int minIndex = 0;
            int maxIndex = word.Length - 1;
            while (true)
            {
                if (minIndex > maxIndex)
                {
                    return true;
                }
                char currentLeftChar = word[minIndex];
                char currentRightChar = word[maxIndex];
                if (char.ToLower(currentLeftChar) != char.ToLower(currentRightChar))
                {
                    return false;
                }

                minIndex++;
                maxIndex--;
            }
        }

        private static bool CraftedIsPalindrome(string word)
        {
            var reversed = new string(word.ToCharArray().Reverse().ToArray());
            return word == reversed;
        }
    }
}
