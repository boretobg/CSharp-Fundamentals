using System;
using System.Linq;

namespace _03._ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitter = new char[] { '\\', '.' };
            var input = Console.ReadLine().Split(splitter).ToArray();
            Console.WriteLine($"File name: {input[input.Length - 2]} \nFile extension: {input[input.Length - 1]}");
        }
    }
}
