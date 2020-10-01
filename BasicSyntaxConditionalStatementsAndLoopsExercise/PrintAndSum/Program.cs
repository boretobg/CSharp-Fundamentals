using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine()); // променлива - тип (int, double, string, char, bool) 
            int last = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = first; i <= last; i++)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
