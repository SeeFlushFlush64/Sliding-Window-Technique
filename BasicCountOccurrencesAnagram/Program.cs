using System;
using System.Collections.Generic;

namespace BasicCountOccurrencesAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "listeninletsentil";
            Console.WriteLine(CountOccurrenceAnagram(myString));
        }

        public static int CountOccurrenceAnagram(string testString)
        {
            int numberOfOccurrences = 0;
            Dictionary<char, int> targetFreq = new Dictionary<char, int>
            {
                { 'l', 1 }, { 'i', 1 }, { 's', 1 }, { 't', 1 }, { 'e', 1 }, { 'n', 1 }
            };

            Dictionary<char, int> windowFreq = new Dictionary<char, int>();
            int left = 0;
            int requiredLength = targetFreq.Count;

            for (int right = 0; right < testString.Length; right++)
            {
                char currentChar = testString[right];
                if (targetFreq.ContainsKey(currentChar))
                {
                    // Add current character to the window
                    if (!windowFreq.ContainsKey(currentChar))
                        windowFreq[currentChar] = 0;
                    windowFreq[currentChar]++;

                    // Check if the window matches the target frequency
                    if (windowFreq[currentChar] == targetFreq[currentChar])
                        requiredLength--;
                }

                // Shrink the window if it exceeds the required size
                if (right - left + 1 > targetFreq.Count)
                {
                    char leftChar = testString[left];
                    if (targetFreq.ContainsKey(leftChar))
                    {
                        if (windowFreq[leftChar] == targetFreq[leftChar])
                            requiredLength++;

                        windowFreq[leftChar]--;
                    }
                    left++;
                }

                // Check if the current window is a valid anagram
                if (requiredLength == 0)
                    numberOfOccurrences++;
            }

            return numberOfOccurrences;
        }
    }
}
