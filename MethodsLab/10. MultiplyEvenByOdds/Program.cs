using System;

namespace _10._MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double sumOdd = 0;
            double sumEven = 0;
            double n = 0; //123
            EvenOddSum(num, sumOdd, sumEven, n);
        }

        static void EvenOddSum(double num, double sumEven, double sumOdd, double n)
        {
            while (n != 0)
            {
                n = Math.Abs(num);
                n %= 10; //3
                if (n % 2 == 0)
                {
                    sumEven += n;
                }
                else
                {
                    sumOdd += n;
                }
                num /= 10;
            }

            double sum = sumEven * sumOdd;
            Console.WriteLine(sum);
        }
       
    }
}
