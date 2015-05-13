using System;

class CountSymbols
{
    static void Main()
    {
        string input = Console.ReadLine();
        int counter = 0;

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input.Length; j++)
            {
                if (input[i] == input[j])
                {
                    counter++;
                }
            }
            
            Console.WriteLine("{0}: {1} time/s", input[i], counter);            
            counter = 0;
        }
    }
}