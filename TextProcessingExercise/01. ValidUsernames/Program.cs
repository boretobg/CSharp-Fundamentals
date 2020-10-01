using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _01._ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ").ToArray();
            List<string> outputs = new List<string>();

            for (int i = 0; i < names.Length; i++)
            {
                string temp = names[i];

                if (names[i].Length >= 3 && names[i].Length <= 16)
                {
                    bool isValid = true;
                    for (int k = 0; k < temp.Length; k++)
                    {
                        if (!(temp[k] == '-' || temp[k] == '_' || char.IsLetterOrDigit(temp[k])))
                        {
                            isValid = false;
                        }
                    }
                    if (isValid)
                    {
                        outputs.Add(temp);
                    }
                }

            }

            for (int i = 0; i < outputs.Count; i++)
            {
                Console.WriteLine(outputs[i]);
            }
        }
    }
}
