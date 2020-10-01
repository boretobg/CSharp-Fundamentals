using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string input = "";
            double totalSpent = 0;

            while (true)
            {
                double gamePrice = 0;
                input = Console.ReadLine();
                if (input == "Game Time")
                {
                    break;
                }

                switch (input)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }

                if (balance >= gamePrice)
                {
                    balance -= gamePrice;
                    totalSpent += gamePrice;
                    Console.WriteLine($"Bought {input}");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
               
                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
        }
    }
}
