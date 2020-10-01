using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();

            string line = Console.ReadLine();
            while (line != "Craft!")
            {
                string[] input = line.Split(" - ");
                string tempCmd = input[0];
                string tempItem = input[1];

                if (tempCmd == "Collect")
                {
                    if (inventory.Contains(tempItem))
                    {
                        line = Console.ReadLine();
                        continue;
                    }
                    inventory.Add(tempItem);
                }
                else if (tempCmd == "Drop")
                {
                    inventory.Remove(tempItem);
                }
                else if (tempCmd == "Combine Items")
                {
                    string[] tempItems = tempItem.Split(":").ToArray();
                    if (inventory.Contains(tempItems[0]))
                    {
                        int index = inventory.IndexOf(tempItems[0]);
                        inventory.Insert(index + 1, tempItems[1]);
                    }
                }
                else if (tempCmd == "Renew")
                {
                    if (inventory.Contains(tempItem))
                    {
                        inventory.Remove(tempItem);
                        inventory.Add(tempItem);
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
