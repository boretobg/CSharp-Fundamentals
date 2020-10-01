using System;
using System.Linq;
using System.Threading;

namespace _09._PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int n = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                n = int.Parse(input);
                int number = n;
                int reverse = 0, rem;
                while (n != 0)
                {
                    rem = n % 10;
                    reverse = reverse * 10 + rem;
                    n /= 10;
                }

                if (number == reverse)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }
    }
}
