using System;
using System.Numerics;

namespace _03._BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i; ;
            }
            Console.WriteLine(result);
        }
    }
}
