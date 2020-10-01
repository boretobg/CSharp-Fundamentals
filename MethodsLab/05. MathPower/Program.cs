using System;

namespace _08._MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            double output = Result(number, pow);
            Console.WriteLine(output);
        }

        static double Result(double number, double pow)
        {
            double result = Math.Pow(number, pow);
            return result;
        }
    }
}
