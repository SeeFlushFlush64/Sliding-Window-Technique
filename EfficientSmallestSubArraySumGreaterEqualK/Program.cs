using System;
namespace EfficientSmallestSubArraySumGreaterEqualK
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 10, 5, 2, 7 };
            int k = 15;
            System.Console.WriteLine(EfficientSmallestSubArraySize(array, k));
            
        }
        static int EfficientSmallestSubArraySize(int[] array, int k)
        {
            int left = 0;
            int windowSum = 0;
            int smallestSize = 0;

            for (int right = 0; right < array.Length; right++)
            {
                windowSum += array[right];
                while (windowSum >= k)
                {
                    smallestSize = right - left + 1;
                    windowSum -= array[left];
                    left++;
                }
            } 
            return smallestSize;
        }
    }
}