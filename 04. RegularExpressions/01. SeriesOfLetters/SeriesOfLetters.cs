using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        char[] ch = Console.ReadLine().ToCharArray();
        List<char> chList = new List<char>();

        chList.Add(ch[0]);
        for (int i = 1; i < ch.Length; i++)
        {
            if (ch[i] != ch[i-1])
            {
                chList.Add(ch[i]);
            }
        }

        foreach (var item in chList)
        {
            Console.Write(item);
        }
        Console.WriteLine();

    }
}