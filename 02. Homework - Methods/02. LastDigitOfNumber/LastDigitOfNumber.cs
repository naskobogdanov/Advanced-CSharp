using System;

class LastDigitOfNumber
{
    static string GetLastDigit(int x)
    {
        string[] numbersAsText = { "Zero" , "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        int lastDigit = x % 10;
        return numbersAsText[lastDigit];
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        string numAsText = GetLastDigit(num);
        Console.WriteLine("The last digit as text is: {0}", numAsText);
    }
}