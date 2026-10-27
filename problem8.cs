using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<double> prices = new List<double>
        {250, 300, 150, 200, 250};

        double total = 0;

        Console.WriteLine("Product prices:");

        foreach (double price in prices)
        {
            Console.WriteLine(price);
            total += price;
        }

        Console.WriteLine("Total before discount = " + total);

        double discount = 0;

        if (total > 1000)
        {
            discount = total * 0.10;
        }

        double finalT = total - discount;

        Console.WriteLine("Discount = " + discount);
        Console.WriteLine("Total after aiscount = " + finalT);


    }
}
