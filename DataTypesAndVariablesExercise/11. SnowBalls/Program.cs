using System;

namespace _11._SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int snow = 0;
            int time = 0;
            int quality = 0;
            double result = 0;
            string output = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                snow = int.Parse(Console.ReadLine());
                time = int.Parse(Console.ReadLine());
                quality = int.Parse(Console.ReadLine());

                result = Math.Pow((snow / time), quality);
                if (result > max)
                {
                    max = (int)result;
                    output = $"{snow} : {time} = {result} ({quality})";
                }
            }

            Console.WriteLine(output);

        }
    }
}
