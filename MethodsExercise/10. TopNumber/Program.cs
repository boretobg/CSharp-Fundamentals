using System;

namespace _10._TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 17; i <= n; i++)
            {
                int sum = 0;
                int num = i;
                int replaceI = i;
                int currNum = i;
                bool isOdd = false;
                while (num != 0)
                {
                    num = replaceI;
                    num %= 10;
                    if (num % 2 != 0)
                    {
                        isOdd = true;
                    }
                    sum += num;
                    replaceI /= 10;
                }

                if (isOdd)
                {
                    if (sum % 8 == 0)
                    {
                        Console.WriteLine(currNum);
                    }
                }

            }
        }
    }
}
