using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _03._InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> users = new List<string>();

            int count = 0;

            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] cmd = input.Split("->").ToArray();

                if (cmd.Contains("Add"))
                {
                    
                    string tempUser = cmd[1];
                    if (users.Contains(tempUser))
                    {
                        Console.WriteLine($"{tempUser} is already registered");
                    }
                    else
                    {
                        List<User> User = new List<User>();
                        
                        users.Add(User);
                    }
                    count++;
                }
                else if (cmd.Contains("Send"))
                {

                }
            }
        }
    }

    class User
    {
        public string name { get; set; }
        public string text { get; set; }

        public User (string Name, string Text)
        {
            this.name = Name;
            this.text = Text;
        }
    }
}
