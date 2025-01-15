using System;
namespace VariableSizedFindSubArrayLength
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(MinSubArray(new int[] { 4, 1, 2, 3, 5, 7, 4, 1 }, 20));
            //target is 6
        }
        static int MinSubArray(int[] array, int targetSum)
        {
            int left = 0;
            int windowSum = 0;
            int minSubArrayLength = int.MaxValue;
    
            for (int right = 0; right < array.Length; right++)
            {
                windowSum += array[right];
                while (windowSum >= targetSum)
                {
                    minSubArrayLength = Math.Min(minSubArrayLength, right - left + 1);
                    windowSum -= array[left];
                    left++;
                }

                
            }


            return minSubArrayLength;
        }
    }
}