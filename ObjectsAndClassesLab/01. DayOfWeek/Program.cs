using System;
using System.Globalization;

namespace _01._DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DayOfWeek(date);
        }

        static void DayOfWeek(string date)
        {
            DateTime output = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(output.DayOfWeek);
        }
    }
}
