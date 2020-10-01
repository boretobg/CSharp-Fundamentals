using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _01._AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Message message = new Message();
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{message.Phrase[rnd.Next(0, message.Phrase.Length)]} {message.Event[rnd.Next(0, message.Event.Length)]} " +
                    $"{message.Author[rnd.Next(0, message.Author.Length)]} - {message.City[rnd.Next(0, message.City.Length)]}");
            }
        }
    }

    class Message
    {
        public string[] Phrase = new string[] { "Excellent product.", "Such a great product.", "I always use that product.",
        "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

        public string[] Event = new string[]{"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
        "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great" };

        public string[] Author = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

        public string[] City = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
    }
}
