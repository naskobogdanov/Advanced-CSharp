using System;
using System.Text.RegularExpressions;

    class ReplaceATag
    {
        static void Main()
        {

            string text = Console.ReadLine();
            string pattern = @"<a.*href=((?:.|\n)*?(?=>))>((?:.|\n)*?(?=<))<\/a>";
            string replace = @"[URL href=$1]$2[/URL]";
            var replaced = Regex.Replace(text, pattern, replace);
            Console.WriteLine(replaced);
            
        }
    }

