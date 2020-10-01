using System;

namespace _02.__PrintNumbersInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                num[i] = numbers;
            }

            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write(num[i] + " ");
            }
        }
    }
}
