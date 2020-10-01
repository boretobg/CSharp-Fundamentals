using System;

namespace _05._AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum = Sum(first, second);

            Console.WriteLine(Substract(third, sum));
        }

        static int Sum(int first, int second)
        {
            return first + second;
        }

        static int Substract(int third, int sum)
        {
            return sum - third;
        }
    }
}
