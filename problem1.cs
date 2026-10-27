using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter a num");
        int num = int.Parse(Console.ReadLine());
        if(num % 2 == 0){
            Console.WriteLine("the number is even");
        }
        else {Console.WriteLine("the number is odd");}
    }
}
