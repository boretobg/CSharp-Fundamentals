using System;

namespace _06._TriplesOfLatinNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int r = 0; r < n; r++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine($"{(char)('a' + i)}{(char)('a' + r)}{(char)('a' + j)}");
                    }
                }
            }
        }
    }
}
