using System;
using System.Linq;

namespace _08._CondenseAarrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray(); //1 2 3 4 5

            while (input.Length != 1)
            {
                int[] condensed = new int[input.Length - 1];
                for (int i = 0; i < input.Length - 1; i++)
                {
                    condensed[i] = input[i] + input[i + 1]; //condensed = 3 5 7 9
                }

                input = condensed;           
            }

            Console.WriteLine(input[0]);
        }
    }
}
