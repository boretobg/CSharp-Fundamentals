using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace _04._Song
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> list = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split('_').ToList();

                string type = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                list.Add(song);
            }

            string typeOutput = Console.ReadLine();

            if (typeOutput == "all")
            {
                foreach (Song song in list)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in list)
                {
                    if (song.TypeList == typeOutput)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

            List<Song> filteredSongs = list.Where(s => s.TypeList == typeOutput).ToList();

            foreach (Song song in filteredSongs)
            {
                Console.WriteLine(song.Name);
            }

        }

    }

    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
