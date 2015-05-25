using System;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();
        string pattern = string.Format(@"(?<=\s|^)[^!.?]*\b{0}\b[^!.?]*[!.?]", word);
        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
        Console.WriteLine();
        foreach (Match item in matches)
        {
            Console.WriteLine(item.Groups[0]);
        }
    }
}