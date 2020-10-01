using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @">>(?<furniture>\w*)<<(?<price>\d+.?\d+)!(?<quantity>\d+)";

            var furnitures = new List<string>();
            double allPrice = 0;
            var input = Console.ReadLine();
            while (input != "Purchase")
            {
                var matches = Regex.Matches(input, regex);

                foreach (Match item in matches)
                {
                    var furniture = item.Groups["furniture"].Value;
                    var price = item.Groups["price"].Value;
                    var quantity = item.Groups["quantity"].Value;

                    furnitures.Add(furniture);
                    allPrice += double.Parse(price) * int.Parse(quantity);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            Console.WriteLine(string.Join(Environment.NewLine, furnitures));
            Console.WriteLine($"Total money spend: {allPrice:f2}");
        }
    }
}
