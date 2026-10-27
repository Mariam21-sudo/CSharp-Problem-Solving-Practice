
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int[] numbers = { 12, 45, 7, 89, 23, 56 };

        int largest = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        Console.WriteLine("Largest Number = " + largest);


    }
}

