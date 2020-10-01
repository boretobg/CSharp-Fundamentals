using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace _03._MessagesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            var records = new List<Records>();

            string regex = @"(?<cmd>[A-Z][a-z]+)=(?<name>[A-Z][a-z]+)=?((?<sent>\d)=(?<received>\d))?(?<receiver>[A-Z][a-z]+)?";

            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                var match = Regex.Matches(input, regex);
                foreach (Match item in match)
                {
                    bool alreadyExists = false;
                    string name = item.Groups["name"].Value;
                    if (item.Groups["cmd"].Value == "Add")
                    {
                        for (int i = 0; i < records.Count; i++)
                        {
                            if (records[i].name == name)
                            {
                                alreadyExists = true;
                                break;
                            }
                        }
                        if (alreadyExists)
                        {
                            continue;
                        }
                        var sent = int.Parse(item.Groups["sent"].Value);
                        var received = int.Parse(item.Groups["received"].Value);
                        Records record = new Records(name, sent, received);
                        records.Add(record);
                    }
                    else if (item.Groups["cmd"].Value == "Message")
                    {
                        bool nameExist = false;
                        bool receiverExist = false;
                        int nameCount = 0;
                        int receiverCount = 0;

                        var receiver = item.Groups["receiver"].Value;
                        for (int i = 0; i < records.Count; i++)
                        {   
                            if (records[i].name == name)
                            {
                                nameExist = true;
                                nameCount = i;
                            }
                            if (records[i].name == receiver)
                            {
                                receiverExist = true;
                                receiverCount = i;
                            }
                        }

                        if (nameExist && receiverExist)
                        {
                            records[nameCount].sent += 1;
                            if ((records[nameCount].sent + records[nameCount].received) >= capacity)
                            {
                                records.RemoveAt(nameCount);
                                Console.WriteLine($"{name} reached the capacity!");
                                receiverCount--;
                            }
                            records[receiverCount].received += 1;
                            if ((records[receiverCount].received + records[receiverCount].sent) >= capacity)
                            {
                                records.RemoveAt(receiverCount);
                                Console.WriteLine($"{receiver} reached the capacity!");
                            }
                        }
                    }
                    else if (item.Groups["cmd"].Value == "Empty")
                    {
                        if (name == "All")
                        {
                            records.RemoveRange(0, records.Count);
                        }
                        else
                        {
                            for (int i = 0; i < records.Count; i++)
                            {
                                if (records[i].name == name)
                                {
                                    records.RemoveAt(i);
                                }
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            var sorted = records.OrderByDescending(x => x.received);
            var ordered = sorted.ThenBy(x => x.name).ToList();

            Console.WriteLine($"Users count: {ordered.Count}");
            for (int i = 0; i < ordered.Count; i++)
            {
                Console.WriteLine($"{ordered[i].name} - {ordered[i].sent + ordered[i].received}");
            }
        }
    }

    class Records
    {
        public string name {get;set;} 
        public int sent { get; set; }
        public int received { get; set; }

        public Records (string Name, int Sent, int Received)
        {
            this.name = Name;
            this.sent = Sent;
            this.received = Received;
        }
    }
}
