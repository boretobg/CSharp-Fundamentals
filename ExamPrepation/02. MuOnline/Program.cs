using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|").ToArray();
            int health = 100;
            int coins = 0;
            bool hasDied = false;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] command = rooms[i].Split().ToArray();

                if (command[0] == "potion") //80 + 40 == 120
                {
                    int value = 0;
                    if (int.Parse(command[1]) + health >= 100)
                    {
                        value = 100 - health;
                        health = 100;
                    }
                    else
                    {
                        value = int.Parse(command[1]);
                        health += int.Parse(command[1]);
                    }
                    Console.WriteLine($"You healed for {value} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command[0] == "chest")
                {
                    coins += int.Parse(command[1]);
                    Console.WriteLine($"You found {int.Parse(command[1])} bitcoins.");
                }
                else
                {
                    health -= int.Parse(command[1]);
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command[0]}.");
                        hasDied = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command[0]}.");
                    }
                }
            }

            if (hasDied)
            {
                 Console.WriteLine($"Best room: {rooms.Length - 1}");
                return;
            }
    
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
    
}
