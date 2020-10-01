using System;

namespace _05._SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); 
            int n = 0;
            int num = 0;

            for (int i = 1; i <= number; i++) //14
            {
                int sum = 0;
                n = i; //14
                num = i; //14
                while (num > 0)
                {
                    n %= 10; //14 % 10 = 4
                    num /= 10; //14 / 10 = 1
                    sum += n;//4
                    n = num;
                }
                bool condition = sum == 7 || sum == 5 || sum == 11;
                Console.WriteLine($"{i} -> {condition}");
            }
        }
    }
}
