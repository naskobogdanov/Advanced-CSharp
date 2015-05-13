using System;
using System.Linq;

class ReverseNumber
{
    static string GetReversedNumber(double num)
    {
        char[] charArray = num.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main()
    {
        Console.Write("Please enter your number: ");
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine("Reversed number is: {0}", GetReversedNumber(number));
    }
}