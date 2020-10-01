using System;

namespace _10._PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int count = 0;
            int N = n;

            while (N >= m)
            {
                if (N == n * 50 / 100 && y != 0 && N != 0)
                {
                    N /= y;
                }
                else
                {
                    N -= m;
                    count++;
                }
            }

            Console.WriteLine(N);
            Console.WriteLine(count);
        }
    }
}
