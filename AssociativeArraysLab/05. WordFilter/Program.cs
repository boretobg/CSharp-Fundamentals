using System;
using System.Linq;

namespace _05._WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < word.Length; i++)
            {
                string temp = word[i];
                if (temp.Length % 2 == 0)
                {
                    Console.WriteLine(temp);
                }
            }
        }
    }
}
