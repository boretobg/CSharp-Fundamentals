using System;

namespace _08._FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double factorialFirst = FactorialFirst(first);
            double factorialSecond = FactorialSecond(second);

            Console.WriteLine($"{FactorialDivision(factorialFirst, factorialSecond):f2}");
        }

        static double FactorialFirst(double first)
        {
            double factorialFirst = 1;
            for (int i = 1; i <= first; i++)
            {
                factorialFirst *= i;
            }

            return factorialFirst;
        }

        static double FactorialSecond(double second)
        {
            double factorialSecond = 1;
            for (int i = 1; i <= second; i++)
            {
                factorialSecond *= i;
            }

            return factorialSecond;
        }

        static double FactorialDivision(double factorialFirst, double factorialSecond)
        {
            return factorialFirst / factorialSecond;
        }
    }
}
