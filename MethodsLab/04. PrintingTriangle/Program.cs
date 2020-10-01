using System;
using System.Security.Cryptography;

namespace _04._PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FirstHalf(n);
            SecondHalf(n);
        }

        static void PrintLine(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void FirstHalf(int n)
        {
            for (int i = 1; i < n; i++)
            {
                PrintLine(i);
            }
        }

        static void SecondHalf(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

    }
}
