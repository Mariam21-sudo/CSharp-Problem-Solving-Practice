
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter grade: ");
        int grade = int.Parse(Console.ReadLine());

        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid Grade");
        }
        else if (grade >= 90)
        {
            Console.WriteLine("Excellent");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Very Good");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Good");
        }
        else if (grade >= 50)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}

