using System;
namespace IntermediateLongestSubstringMostKDistinctChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string apps = "aabacbebebe";
            int k = 3;
            System.Console.WriteLine(LongestSubStringMostKDistinct(apps, k));
        }
        static string LongestSubStringMostKDistinct(string apps, int k)
        {
            string longestSubstring = "";
            string currentLongest = "";
            int left = 0;
            int longestSize = 0;
            HashSet<char> distinctChars = new HashSet<char>();
            for (int right = 0; right < apps.Length; right++)
            {
                if (distinctChars.Count() <= k)
                {
                    if (distinctChars.Count().Equals(k) && !distinctChars.Contains(apps[right]))
                    {
                        char toBeRemoved = apps[left];
                        currentLongest = apps.Substring(left, right - left);
                        longestSubstring = currentLongest.Length > longestSubstring.Length ? currentLongest : longestSubstring;
                        currentLongest = longestSubstring;
                        while (currentLongest.Contains(toBeRemoved))
                        {
                            currentLongest = currentLongest.Remove(0, 1);
                            left++;
                        }
                        distinctChars.Remove(toBeRemoved);  
                    }
                    else if (distinctChars.Count().Equals(k) && right.Equals(apps.Length - 1))
                    {
                        currentLongest = apps.Substring(left, right - left + 1);
                        longestSubstring = currentLongest.Length > longestSubstring.Length ? currentLongest : longestSubstring;
                    }
                    if (!distinctChars.Contains(apps[right]))
                    {
                        distinctChars.Add(apps[right]);
                    }
                }
            }
            return longestSubstring;
        }
    }
}