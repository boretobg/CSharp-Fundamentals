using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            PrintTheCharsBetween(start, end);
        }

        static void PrintTheCharsBetween(char start, char end)
        {
            if (start > end)
            {
                for (int i = end + 1; i < start; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }
        }

    }
}
