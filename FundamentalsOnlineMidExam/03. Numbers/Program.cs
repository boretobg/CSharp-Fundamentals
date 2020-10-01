using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            double count = 0;

            for (int i = 1; i <= nums.Length; i++)
            {
                sum += nums[i - 1];
                count = i;
            }

            double average = sum / count;
            List<int> greather = new List<int>();
            bool hasGreather = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > average)
                {
                    hasGreather = true;
                    greather.Add(nums[i]);
                }
            }

            if (!hasGreather)
            {
                Console.WriteLine("No");
                return;
            }

            greather.Sort();
            count = 0;
            for (int i = greather.Count - 1; i >= 0; i--)
            {
                if (count == 5)
                {
                    break;
                }
                count++;
                Console.Write(greather[i] + " ");
            }
        }
    }
}
