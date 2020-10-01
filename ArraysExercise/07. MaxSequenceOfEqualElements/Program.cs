using System;
using System.Linq;
using System.Runtime.Versioning;

namespace _07._MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int currSeq = int.MinValue;
            int countSeq = 0;
            int maxSeqCount = 0;
            int maxSeq = 0;

            for (int i = numbers.Length - 1; i >= 0; i--) //2 1 1 2 3 3 2 2 2 1 (10)
            {
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
                }
            }

            for (int i = 0; i < maxSeqCount; i++)
            {
                Console.Write($"{maxSeq} ");
            }
        }
    }
}
