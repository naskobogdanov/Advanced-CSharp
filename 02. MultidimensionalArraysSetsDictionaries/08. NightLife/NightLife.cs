using System;
using System.Collections.Generic;

class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightLife = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        string[] tokens;
        string city = String.Empty;
        string club = String.Empty;
        string singer = String.Empty;
        string eventInfo = Console.ReadLine();

        while (eventInfo != "END")
        {
            tokens = eventInfo.Split(';');
            city = tokens[0];
            club = tokens[1];
            singer = tokens[2];

            if (!nightLife.ContainsKey(city))
            {
                nightLife[city] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!nightLife[city].ContainsKey(club))
            {
                nightLife[city][club] = new SortedSet<string>();
            }
            nightLife[city][club].Add(singer);

            eventInfo = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Sorted output: ");
        Console.WriteLine();
        foreach (var cityPair in nightLife)
        {
            Console.WriteLine(cityPair.Key);
            foreach (var venuePair in cityPair.Value)
            {
                Console.WriteLine("->{0}: {1}", venuePair.Key, String.Join(", ", venuePair.Value));
            }
        }
        Console.WriteLine();
    }
}