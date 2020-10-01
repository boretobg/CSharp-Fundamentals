using System;
using System.Linq;

namespace _03._RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] numbers = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                numbers[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero) ;
                Console.WriteLine($"{nums[i]} => {numbers[i]}");
            }
        }
    }
}
