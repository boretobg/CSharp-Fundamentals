using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftuniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"%(?<name>[A-Z][a-z]+)%<(?<product>\w+)>([A-Za-z]+)?\|(?<count>[0-9]+)\|([A-Za-z]+)?(?<price>\d+.?\d+)\$";
            double totalPrice = 0;

            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                var matches = Regex.Matches(input, regex);
                foreach (Match item in matches)
                {
                    double tempPrice = int.Parse(item.Groups["count"].Value) * double.Parse(item.Groups["price"].Value);
                    totalPrice += tempPrice;
                    Console.WriteLine($"{item.Groups["name"].Value}: {item.Groups["product"].Value} - {tempPrice:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}

