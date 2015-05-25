using System;
using System.Collections.Generic;
using System.Linq;


class Palindromes
{
    static void Main()
    {
        string[] wordsInText = Console.ReadLine().Split(new[] { ',', ' ', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> words = new List<string>();
        List<string> palindromesWords = new List<string>();

        foreach (var item in wordsInText)
        {
            words.Add(item);
        }

        for (int i = 0; i < words.Count; i++)
        {
            char[] ch = words[i].ToCharArray();
            string reversedCh = new string(ch);
            Array.Reverse(ch);
            string reverserStr = new string(ch);
            for (int j = 0; j < words.Count; j++)
            {
                if (reverserStr == words[j])
                {
                    palindromesWords.Add(words[j]);
                }
            }
        }

        palindromesWords.Sort();
        Console.WriteLine(string.Join(", ", palindromesWords.Distinct().ToList().ToArray()));
    }
}