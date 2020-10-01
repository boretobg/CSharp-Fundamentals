using System;
using System.Linq;

namespace _01._TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "Decode")
            {
                string[] command = input.Split("|").ToArray();
                switch (command[0])
                {
                    case "Move": //Move {number of letters}
                        int number = int.Parse(command[1]);
                        string letters = string.Empty;
                        for (int i = 0; i < number; i++)
                        {
                            letters += message[i];
                        }
                        message = message.Remove(0, number);
                        message += letters;
                        break;
                    case "Insert":
                        int index = int.Parse(command[1]);
                        string value = command[2];
                        message = message.Insert(index, value);
                        break;
                    case "ChangeAll":
                        string oldValue = command[1];
                        string newValue = command[2];
                        message = message.Replace(oldValue, newValue);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
