using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();
            string[] output = Array.Empty<string>();

            for (int i = 0; i < secondInput.Length; i++)
            {
                for (int j = 0; j < firstInput.Length; j++)
                {
                    if (firstInput[j] == secondInput[i])
                    {
                        Console.Write($"{firstInput[j]} ");
                    }
                }
            }

        }
    }
}
