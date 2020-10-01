using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SortedDictionary<int, int> nums = new SortedDictionary<int, int>();
            int count = 0;

            for (int i = 0; i < numbers.Length; i++) //1 3 4 1 3
            {
                count = 0;
                if (!nums.ContainsKey(numbers[i]))
                {
                    count++;
                    nums.Add(numbers[i], count);
                    continue;
                }
                nums[numbers[i]] += 1;
            }

            foreach (var num in nums)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
