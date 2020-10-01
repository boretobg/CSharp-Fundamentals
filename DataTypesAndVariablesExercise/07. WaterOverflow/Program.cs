using System;

namespace _07._WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort n = ushort.Parse(Console.ReadLine());
            ushort liters = 0;
            int capacity = 255;

            for (int i = 1; i <= n; i++)
            {
                liters = ushort.Parse(Console.ReadLine());
                if (liters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                capacity -= liters;
            }

            Console.WriteLine(255 - capacity);
        }
    }
}
