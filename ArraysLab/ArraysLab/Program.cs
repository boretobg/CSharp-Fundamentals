using System;
using System.Linq;

namespace ArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] {"Monday", "Tuesday", "Wednesday",
                                        "Thursday", "Friday", "Saturday", "Sunday" };

            int num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 7)
            {
                Console.WriteLine(days[num - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
