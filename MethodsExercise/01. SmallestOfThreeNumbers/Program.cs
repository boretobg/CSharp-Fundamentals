using System;

namespace _01._SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallestNumber();
        }

        static void SmallestNumber()
        {
            int min = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine(min);
        }
    }
}
