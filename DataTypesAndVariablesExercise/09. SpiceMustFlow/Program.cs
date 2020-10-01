using System;

namespace _09._SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine()); //111
            uint sum = 0;
            int dayCount = 0;

            if (n >= 100)
            {
                while (n != 0)
                {
                    uint f = n - 26;
                    n -= 10;
                    sum += f;
                    if (n < 100)
                    {
                        sum -= 26;
                        dayCount++;
                        break;
                    }
                    dayCount++;
                }

            }
            Console.WriteLine(dayCount);
            Console.WriteLine(sum);
        }
    }
}
