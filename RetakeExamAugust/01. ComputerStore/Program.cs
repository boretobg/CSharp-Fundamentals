using System;

namespace _01._ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTaxes = 0;
            double price = 0;

            string input = Console.ReadLine();
            while (input != "special" && input != "regular")
            {
                if (double.Parse(input) < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }

                price += double.Parse(input);
                input = Console.ReadLine();
            }

            priceTaxes = price * 0.2;
            double total = priceTaxes + price;

            if (total == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            if (input == "special")
            {
                total -= total * 0.1;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {price:f2}$");
            Console.WriteLine($"Taxes: {priceTaxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {total:f2}$");
        }
    }
}
