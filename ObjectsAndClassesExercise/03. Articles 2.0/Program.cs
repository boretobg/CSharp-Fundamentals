using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Articles> list = new List<Articles>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();
                Articles articles = new Articles(input[0], input[1], input[2]);
                list.Add(articles);
            }

            string cmd = Console.ReadLine();
            if (cmd == "title")
            {
                List<string> output = new List<string>();
                for (int i = 0; i < list.Count; i++)
                {
                 

                }
            }
            else if (cmd == "content")
            {

            }
            else
            {

            }
        }
    }

    class Articles
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Articles(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
    }
}
