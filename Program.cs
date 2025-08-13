using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;
class Program
{
    static void Main()
    {
        Sum obj = new Sum();
        Console.WriteLine("enter no:");
        int number = int.Parse(Console.ReadLine());
        int result = obj.CalculateSum(number);
        Console.WriteLine("sum of digit : " + result);
    }
}