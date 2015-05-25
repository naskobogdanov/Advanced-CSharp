using System;
using System.Linq;

class CountSubstringOccurrences
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string substringToMatch = Console.ReadLine().ToLower();
        Console.WriteLine(TextTool.CountStringOccurrences(text, substringToMatch));
    }

    public static class TextTool
    {
        public static int CountStringOccurrences(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += 1;
                count++;
            }
            return count;
        }
    }
}