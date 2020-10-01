using System;

namespace _12._RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int n = 0;
            bool condition = false;
            for (int i = 1; i <= number; i++)
            {
                n = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                condition = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", n, condition);
                sum = 0;
                i = n;
            }

        }
    }
}
