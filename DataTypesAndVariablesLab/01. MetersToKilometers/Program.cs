﻿using System;
using System.Transactions;

namespace _01._MetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
