using System;
class Program
{
    static void Main()
    {
        reverse obj = new reverse();
        Console.WriteLine("enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Reversed number = " + obj.get_reverse(number));
    }
}