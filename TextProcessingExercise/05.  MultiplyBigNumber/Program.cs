using System;
using System.Numerics;
using System.Text;

namespace _05.__MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int over5Temp = 0;


            for (int i = first.Length - 1; i >= 0; i--) //2546
            {
                int temp = int.Parse(first[i].ToString());
                
                sb.Append(int.Parse(first[i].ToString()) * second);
            }

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                Console.Write(sb[i]);
            }
        }
    }
}
