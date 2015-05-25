using System;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        char[] ch = str.ToCharArray();

        Console.WriteLine();
        Console.WriteLine("Your hex numbers are: ");
        foreach (char c in ch)
        {
            int value = Convert.ToInt32(c);
            string hexOutput = String.Format("{0:X}", value);
            Console.Write("\\u00{0}", hexOutput.ToLower());
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}