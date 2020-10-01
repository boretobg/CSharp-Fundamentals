using Microsoft.VisualBasic.FileIO;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray(); //1 2 3 4 5
            int n = int.Parse(Console.ReadLine()); //2


            for (int i = 0; i < n; i++)
            {
                int firstElement = array[0]; //1

                int[] temp = new int[array.Length]; // 0 0 0 0 0

                for (int j = 1; j < array.Length; j++)
                {
                    temp[j - 1] = array[j]; //2 3 4 5
                }

                temp[temp.Length - 1] = firstElement; //2 3 4 5 + 1
                array = temp; // 2 3 4 5 1
            }

            Console.WriteLine(String.Join(' ', array));
        }
    }
}
