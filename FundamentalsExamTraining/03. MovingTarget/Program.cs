using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _03._MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                int currNum = 0;
                int currIndex = 0;
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                currIndex = int.Parse(input[1]);         
                if (input[0] == "Shoot")
                {
                    if (int.Parse(input[1]) > numbers.Length)
                    {
                        continue;
                    }

                    numbers[currIndex] -= int.Parse(input[2]);
                    currNum = numbers[currIndex];
                    if (numbers[currIndex] <= 0)
                    {
                        var numbersList = numbers.ToList();
                        numbersList.Remove(currNum);
                        numbers = numbersList.ToArray();
                    }

                    continue;
                }

                if (input[0] == "Add")
                {
                    if (int.Parse(input[1]) > numbers.Length)
                    {
                        Console.WriteLine("Invalid placement!");
                        continue;
                    }

                    numbers[int.Parse(input[1])] += int.Parse(input[2]);
                }

                if (input[0] == "Strike")
                {
                    if (int.Parse(input[2]) < numbers.Length / 2)
                    {
                        currIndex = int.Parse(input[1]) - 1;
                        for (int i = currIndex; i <= currIndex + 2; i++)
                        {
                            numbers[currIndex] = 0;
                            currNum = 0;
                            var numbersList = numbers.ToList();
                            numbersList.Remove(currNum);
                            numbers = numbersList.ToArray();
                        }
                        continue;
                    }
                    Console.WriteLine("Strike missed!");
                }
            }

            Console.WriteLine(string.Join("|", numbers));
        }
    }
}
