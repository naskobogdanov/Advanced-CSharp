using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        char[] ch = str.ToCharArray();
        Array.Reverse(ch);
        string reverserStr = new string(ch);
        Console.WriteLine();
        Console.WriteLine("Your reversed string is: {0}", reverserStr);
        Console.WriteLine();
    }
}