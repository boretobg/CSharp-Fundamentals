using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = 0;
            int allSum = 0;
            int n = number;

            while (true)
            {
                int sumDigit = 1;
                digit = n % 10; // getting the last digit from the number
                if (n == 0)
                {
                    break;
                }
                n /= 10; // removing the last digit from the number
                for (int i = 1; i <= digit; i++) // for example digit = 5, loop goes untill <= 5 (1, 2, 3, 4, 5)
                {
                    sumDigit *= i; // multiplying every digit (1x2x3x4x5)
                }
                allSum += sumDigit; // allSum from every multiplying
            }

            if (allSum == number) // check if number is strong
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
