using System;
using System.Runtime.ExceptionServices;

namespace _09._GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Comparison(input);
        }

        static void Comparison(string input)
        {
            int max = int.MinValue;
            string maxString = "";

            switch (input)
            {
                case "string":
                    for (int i = 0; i < 2; i++)
                    {
                        string result = Console.ReadLine();
                        foreach (char c in result)
                        {
                            if (c > max)
                            {
                                max = c;
                                maxString = result;
                            }
                        }
                    }
                    Console.WriteLine(maxString);
                    break;
                case "char":
                    for (int i = 0; i < 2; i++)
                    {
                        char result = char.Parse(Console.ReadLine());
                        if (result > max)
                            max = result;
                    }
                    Console.WriteLine((char)max);
                    break;
                case "int":
                    for (int i = 0; i < 2; i++)
                    {
                        int result = int.Parse(Console.ReadLine());
                        if (result > max)
                            max = result;
                    }
                    Console.WriteLine(max);
                    break;
            }


        }
    }
}
