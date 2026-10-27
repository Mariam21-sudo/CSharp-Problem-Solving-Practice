
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }

    }
}
