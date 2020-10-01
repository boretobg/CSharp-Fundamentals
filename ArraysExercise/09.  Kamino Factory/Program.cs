using System;
using System.Linq;

namespace _09.__Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] currArray = new int[lenght];
            int[] bestArray = new int[lenght];
            string input = "";

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                int[] numbers = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int currSeq = int.MinValue;
                int countSeq = 0;
                int maxSeqCount = 0;
                int maxSeq = 0;

                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    currArray = numbers;
                    if (numbers[i] != currSeq)
                    {
                        countSeq = 0;
                        currSeq = numbers[i];
                        countSeq++;
                        continue;
                    }
                    countSeq++;
                    if (countSeq >= maxSeqCount)
                    {
                        maxSeqCount = countSeq;
                        maxSeq = currSeq;
                        bestArray = currArray;
                    }
                }

                if (currArray > bestArray)
                {

                }
            }
        }
    }
}
