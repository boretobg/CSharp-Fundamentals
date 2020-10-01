
using System;
using System.Collections.Generic;

namespace _05._DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string numbers = "";
            string letters = "";
            string others = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers += input[i];
                }
                else if (char.IsLetter(input[i]))
                {
                    letters += input[i];
                }
                else
                {
                    others += input[i];
                }
            }

            Console.WriteLine($"{numbers}\n{letters}\n{others}");
        }
    }
}
