using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _01._EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string Inputemail = Console.ReadLine();
            List<string> email = new List<string>();
            for (int i = 0; i < Inputemail.Length; i++)
            {
                email.Add(Inputemail[i].ToString());
            }
       

            string line = Console.ReadLine();
            while (line != "Complete")
            {
                string[] input = line.Split().ToArray();
                if (input.Contains("Upper"))
                {
                    for (int i = 0; i < email.Count; i++)
                    {
                        email[i] = email[i].ToUpper();
                    }
                    Console.WriteLine(string.Join("", email));
                }
                else if (input.Contains("Lower"))
                {
                    for (int i = 0; i < email.Count; i++)
                    {
                        email[i] = email[i].ToLower();
                    }
                    Console.WriteLine(string.Join("", email));
                }
                else if (input.Contains("GetDomain"))
                {
                    int count = int.Parse(input[1]); //abcdef
                    int temp = count;
                    for (int i = 0; i < temp; i++)  //012345
                    {
                        Console.Write(email[email.Count - count]);
                        count--;
                    }
                    Console.WriteLine();
                }
                else if (input.Contains("GetUsername"))
                {
                    bool hasChar = false;
                    for (int i = 0; i < email.Count; i++)
                    {
                        if (email[i] == "@")
                        {
                            for (int j = 0; j < i; j++)         //•	"Replace {char}" with "-"
                            {
                                Console.Write(email[j]);
                            }
                            Console.WriteLine();
                            hasChar = true;
                            break;
                        }
                    }

                    if (!hasChar)
                    {
                        Console.WriteLine($"The email {string.Join("", email)} doesn't contain the @ symbol.");
                    }
                }
                else if (input.Contains("Replace"))
                {
                    string temp = input[1];
                    for (int i = 0; i < email.Count; i++)
                    {
                        if (email[i] == temp)
                        {
                            email[i] = "-";
                        }
                    }
                    Console.WriteLine(string.Join("", email));
                }
                else if (input.Contains("Encrypt"))
                {
                    for (int i = 0; i < email.Count; i++)
                    {
                        char temp = char.Parse(email[i]);
                        Console.Write((int)temp + " ");
                    }
                    Console.WriteLine();
                }

                line = Console.ReadLine();
            }
        }
    }
}
