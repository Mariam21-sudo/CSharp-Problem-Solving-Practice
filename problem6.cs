
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<string> students = new List<string>
        {"Ahmed", "Mona", "Ali", "Sara", "Omar"};

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        students.Add("Nour");

        Console.WriteLine("Updated List:");

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }


    }
}
