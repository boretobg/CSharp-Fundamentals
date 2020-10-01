using System;

namespace _02._SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number != 0)
            {
                int n = number; 
                n %= 10; 
                sum += n;
                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
