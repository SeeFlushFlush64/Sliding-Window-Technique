using System;
namespace MaxSumInSubArrayK
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(MaxSumInSubArray(new int[] {4, 2, 3, 1}, 2));
        }
        public static int MaxSumInSubArray(int[] array, int k)
        {
            int maxSum = 0;
            int start = 0;
            int windowSum = 0;
            // what to do?
            // set the windowSum as the first element array[0], 4
            // create a for loop to create a window (subArray) and find the sum of each window
            // since we already have the first element, 4, as the windowSum, and the k is just 2
            // we just need to add the second element, which is array[1], 2
            // we already have the windowSum, which is array[0] + array[1] = 4 + 2 = 6
            // we need to compare the windowSum against maxSum, 6 > 0
            // since windowSum is greater than maxSum, we will replace the maxSum with the windowSum
            // when getting the next windowSum, no need to start at the array[1], which is 2
            // just subtract the value of array[0] from the windowSum to proceed adding the value of array[3]

            for (int i = 0; i < array.Length; i++)
            {
                windowSum += array[i];
                // at i = 0, condition is 0 - 0 + 1 not equal to 2
                // at i = 1, condition is 1 - 0 + 1 equal to 2
                //trigger the if statement
                // at i = 2, condition is 2 - 1 + 1 equal to 2
                //trigger the if statement
                // at i = 3, condition is 3 - 2 + 1 equal to 2
                //trigger the if statement

                if (i - start + 1 == k)
                {
                    maxSum = windowSum > maxSum ? windowSum : maxSum;
                    windowSum -= array[start];
                    start++;
                }
            }
            return maxSum;
        }
    }
}