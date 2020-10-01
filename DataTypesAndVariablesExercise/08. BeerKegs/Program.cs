using System;

namespace _08._BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string name = String.Empty;
            float radius = 0;
            int height = 0;

            double max = double.MinValue; //10
            string nameMax = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                name = Console.ReadLine();
                radius = float.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height; //10
                if (volume >= max)
                {
                    nameMax = name;
                    max = volume;
                }
            }

            Console.WriteLine(nameMax);
        }
    }
}
