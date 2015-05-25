using System;
using System.Collections.Generic;

class LetterschangeNumbers
{
    static void Main()
    {
        string[] text = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        List<char> symbols = new List<char>();
        double sum = 0;

        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < text[i].Length; j++)
            {
                symbols.Add(text[i][j]);
            }
            if (symbols[i][j] > 47 && symbols[i][j] < 58)
            {
                
            }
        }

        
    }
}