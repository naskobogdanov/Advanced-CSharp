using System;

class TextFilter
{
    static void Main()
    {
        Console.Write("Enter the banned words: ");
        string[] bannedWOrds = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Enter the text:");
        string text = Console.ReadLine();

        for (int i = 0; i < bannedWOrds.Length; i++)
        {
            text = text.Replace(bannedWOrds[i], new string('*', bannedWOrds[i].Length));
        }
        Console.WriteLine();
        Console.WriteLine("The text with censored words is: ");
        Console.WriteLine();
        Console.WriteLine(text);
    }
}