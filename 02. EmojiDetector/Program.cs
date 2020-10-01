using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _02._EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int num = 0;
            List<int> numbers = new List<int>();

            CheckNumber(input, num, numbers);
            Console.WriteLine(CoolTreshhold(numbers));


        }

        static void CheckNumber(string[] input, int num, List<int> numbers)
        {
            for (int i = 0; i < input.Length; i++)
            {

                for (int r = 0; r <= 9; r++)
                {
                    string n = r.ToString();
                    if (input[i].Contains(n))
                    {
                        numbers.Add(int.Parse(n));
                    }
                }

                //bool hasString = false;
                //for (int j = 'a'; j <= 'z'; j++)
                //{
                //    if (input[i].Contains((char)j))
                //    {
                //        hasString = true;
                //        break;
                //    }
                //}

                //if (hasString)
                //{
                //    continue;
                //}
                //else
                //{
                //    numbers.Add(int.Parse(input[i]));
                //}
            }
        }
        static long CoolTreshhold(List<int> numbers)
        {
            long numSum = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                int temp = numbers[i];
                while (temp != 0)
                {
                    numSum *= temp % 10;
                    temp /= 10;
                }
            }

            return numSum;
        }
        static void ValidEmojiCheck(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                string temp = input[i];
                int count = 0;
                bool hasUpper = false;

                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] == ':' || temp[j] == '*')
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }

                    if (count == 2)
                    {
                        if (hasUpper)
                        {

                        }
                        else
                        {
                            for (int h = 'A'; h <= 'Z'; h++)
                            {
                                if (temp[j] == (char)h)
                                {
                                    hasUpper = true;
                                    break;
                                }
                            }
                        }
                    }


                }

            }
        }

    }
}

