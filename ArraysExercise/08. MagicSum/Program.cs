using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _08._MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); //1 7 6 2 19 23
            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++) //1
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == magicSum)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                    }
                }
            }
        }
    }
}
