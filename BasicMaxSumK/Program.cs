using System;
namespace BasicMaxSumK
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] sales = new int[] { 70, 10, 30, 80, 20, 40, 50, 60 };
            int[] sales = new int[] { 10, 20, 30, 40, 50, 60, 70 };
            System.Console.WriteLine(MaxSum(sales, 3));
            
        }
        public static int MaxSum(int[] sales, int k)
        {
            int maxSum = 0;
            int windowSum = 0;
            int left = 0; // intended for subtraction
            // int right is intended for addition
            for (int right = 0; right < sales.Length; right++)
            {
                windowSum += sales[right];
                // right = 2
                // left = 0
                // k = 3
                // right = 3
                // left = 1
                
                if (right - left + 1 == k)
                {
                    maxSum = Math.Max(maxSum, windowSum);
                    windowSum -= sales[left];
                    left++;
                }
            }
            return maxSum;
        }
    }
}