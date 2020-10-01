using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double coins = 0;
            double coinsSum = 0;
            bool hasStarted = false;

            while (true)
            {
                while (!hasStarted)
                {
                    input = Console.ReadLine();
                    if (input == "Start")
                    {
                        hasStarted = true;
                        break;
                    }
                    coins = double.Parse(input);
                    if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                    {
                        coinsSum += coins;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {coins}");
                    }
                }

                double priceProduct = 0;
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                switch (input)
                {
                    case "Nuts": priceProduct = 2.0; break;
                    case "Water": priceProduct = 0.7; break;
                    case "Crisps": priceProduct = 1.5; break;
                    case "Soda": priceProduct = 0.8; break;
                    case "Coke": priceProduct = 1.0; break;
                    default: Console.WriteLine("Invalid product"); break;
                }

                if (coinsSum <= 0) break;

                if (coinsSum >= priceProduct)
                {
                    coinsSum -= priceProduct;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }

            Console.WriteLine($"Change: {coinsSum:f2}");
        }
    }
}
