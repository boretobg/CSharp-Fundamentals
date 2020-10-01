using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            List<Item> items = new List<Item>();

            string line = Console.ReadLine();
            while (line != "buy")
            {
                bool alreadyExists = false;
                input = line.Split().ToList();
                Item item = new Item(input[0], double.Parse(input[1]), double.Parse(input[2]));
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].name == input[0])
                    {
                        items[i].quantity += double.Parse(input[2]);
                        if (items[i].price != double.Parse(input[1]))
                        {
                            items[i].price = double.Parse(input[1]);
                            alreadyExists = true;
                        }
                    }
                }
                if (alreadyExists)
                {
                    line = Console.ReadLine();
                    continue;
                }
                items.Add(item);
                line = Console.ReadLine();
            }

            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{items[i].name} -> {items[i].price * items[i].quantity:f2}");
            }
        }
    }


    class Item
    {
        public string name { get; set; }
        public double price { get; set; }
        public double quantity { get; set; }

        public Item(string Name, double Price, double Quantity)
        {
            this.name = Name;
            this.price = Price;
            this.quantity = Quantity;
        }
    }
}
