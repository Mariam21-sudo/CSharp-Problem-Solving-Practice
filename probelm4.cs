
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int[] numbers = { 10, 20, 30, 40, 50 };
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("Sum = " + sum);

    }
}
