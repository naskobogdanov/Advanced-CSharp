using System;

class SequencesOfEqualStrings
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(' ');

        Console.Write("{0} ", arr[0]);
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] != arr[i+1])
            {
                Console.WriteLine();
                Console.Write("{0} ", arr[i + 1]);
            }
            else
            {
                Console.Write("{0} ", arr[i + 1]);
            }
        }
        Console.WriteLine();
    }
}