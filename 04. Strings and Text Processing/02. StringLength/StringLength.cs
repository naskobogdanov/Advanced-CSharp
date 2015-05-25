using System;

class StringLength
{
    static void Main()
    {
        string str = Console.ReadLine();
        char[] ch = str.ToCharArray();

        Console.WriteLine();
        if (ch.Length >= 20)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write(ch[i]);
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = 0; i < ch.Length; i++)
            {
                Console.Write(ch[i]);
            }
            Console.WriteLine(new string ('*', 20-ch.Length));            
        }
        Console.WriteLine();
    }
}