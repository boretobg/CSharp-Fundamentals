using System;

namespace _04._SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                sum += input;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
