using System;
using System.Linq;

namespace _06._EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++) //1 2 3 3 
            {
                int rightSum = 0;
                int leftSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += input[j];
                }

                for (int b = i + 1; b < input.Length; b++)
                {
                    rightSum += input[b];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
