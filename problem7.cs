
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80 };

        Console.Write("Enter a number to search: ");
        int target = int.Parse(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                Console.WriteLine("Found");
                Console.WriteLine("Index = " + i);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Not Found");
        }

    }
}

