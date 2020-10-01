using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = count * 8.45;
                            break;
                        case "Saturday":
                            price = count * 9.8;
                            break;
                        case "Sunday":
                            price = count * 10.46;
                            break;
                    }

                    if (count >= 30)
                    {
                        price -= price * 0.15;
                    }

                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = count * 10.9;
                            break;
                        case "Saturday":
                            price = count * 15.6;
                            break;
                        case "Sunday":
                            price = count * 16;
                            break;
                    }

                    if (count >= 100)
                    {
                        price -= 10 * 10.9;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = count * 15;
                            break;
                        case "Saturday":
                            price = count * 20;
                            break;
                        case "Sunday":
                            price = count * 22.5;
                            break;
                    }

                    if (count >= 10 && count <= 20)
                    {
                        price -= price * 0.05;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {price:f2}");

        }
    }
}
