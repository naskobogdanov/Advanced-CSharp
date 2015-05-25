using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text = Console.ReadLine();
        
        string mail = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@[a-z]+\-?[a-z]+(?:\.[a-z]+)+)\b";
        Regex rgMail = new Regex(mail);
        MatchCollection matches = rgMail.Matches(text);
        Console.WriteLine();
        foreach (Match item in matches)
        {
            Console.WriteLine(item.Groups[0]);
        }
    }
}