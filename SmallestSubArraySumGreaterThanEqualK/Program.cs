using System;
namespace SmallestSubArraySumGreaterThanEqualK
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 10, 5, 2, 7 };
            int k = 15;
            Console.WriteLine(SmallestSubArraySize(array, k));
            
        }
        static int SmallestSubArraySize(int[] array, int k)
        {
            List<int> subArray = new List<int>();
            List<int> subArraySizes = new List<int>();
            int left = 0;
            for (int right = 0; right < array.Length; right++)
            {
                subArray.Add(array[right]);
                if (subArray.Sum() >= k)
                {
                    subArraySizes.Add(subArray.Count);
                    subArray.Remove(subArray[left]);
                }
                if (subArray.Sum() >= k)
                {
                    subArraySizes.Add(subArray.Count);
                }
                if (subArraySizes.Count.Equals(0) && right.Equals(array.Length - 1))
                {
                    return 0;
                }
                
            }
            return subArraySizes.Min();
        }
    }
}