using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace ArraysMoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = String.Empty;
            int[] sums = new int[n];

            for (int i = 0; i < n; i++)
            {
                int vowelSum = 0;
                int consonantSum = 0;
                int sum = 0;

                name = Console.ReadLine();
                int lenght = name.Length;

                for (int j = lenght - 1; j >= 0; j--)
                {
                    if (name[j] == 'a' || name[j] == 'e' || name[j] == 'i' || name[j] == 'o' || name[j] == 'u' ||
                        name[j] == 'A' || name[j] == 'E' || name[j] == 'I' || name[j] == 'O' || name[j] == 'U')
                    {
                        vowelSum += name[j] * lenght;
                    }
                    else
                    {
                        consonantSum += name[j] / lenght;
                    }
                }
                sum = vowelSum + consonantSum;
                sums[i] = sum;
            }

            for (int i = 0; i < sums.Length; i++)
            {
                int temp = 0;
                for (int j = i + 1; j < sums.Length; j++)
                {
                    if (sums[i] > sums[j])
                    {
                        temp = sums[i];
                        sums[i] = sums[j];
                        sums[j] = temp;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sums[i]);
            }
        }
    }
}
