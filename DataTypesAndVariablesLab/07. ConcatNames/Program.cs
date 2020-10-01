using System;

namespace _07._ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();

            Console.WriteLine($"{first}{third}{second}");
        }
    }
}
