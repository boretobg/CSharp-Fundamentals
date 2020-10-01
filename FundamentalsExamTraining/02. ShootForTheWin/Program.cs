using System;
using System.Linq;

namespace _02._ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targetValue = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] currentValue = new int[targetValue.Length];
            string input = string.Empty;
            int index = 0;
            int currentIndex = 0;
            int count = 0;

            while (true) 
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                index = int.Parse(input);
                if (index > targetValue.Length - 1)
                {
                    continue;
                }

                currentIndex = targetValue[index];
                targetValue[index] = -1;
                count++;
                for (int i = 0; i < targetValue.Length; i++)
                {
                    if (targetValue[i] == -1)
                    {
                        continue;
                    }

                    if (targetValue[i] <= currentIndex)
                    {
                        targetValue[i] += currentIndex;
                        continue;
                    }

                    if (targetValue[i] > currentIndex)
                    {
                        targetValue[i] -= currentIndex;
                    }
                }

                currentValue = targetValue;
            }

            Console.Write($"Shot targets: {count} -> ");
            for (int i = 0; i < targetValue.Length; i++)
            {
                Console.Write($"{currentValue[i]} ");
            }
        }
    }
}
