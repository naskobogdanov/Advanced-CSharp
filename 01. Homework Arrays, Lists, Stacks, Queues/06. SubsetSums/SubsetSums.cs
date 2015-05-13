using System;
using System.Collections.Generic;
using System.Linq;

public static class SubsetSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var matches = from subset in nums.SubSetsOf()
                      where subset.Sum() == n
                      select subset;

        foreach (var match in matches)
        {
            Console.WriteLine(match.Select(m => m.ToString()).Aggregate((a, num) => a + " + " + num) + " = " + n.ToString());
        }
        
        Console.WriteLine();
    }

    public static IEnumerable<IEnumerable<T>> SubSetsOf<T>(this IEnumerable<T> source)
    {
        if (!source.Any())
            return Enumerable.Repeat(Enumerable.Empty<T>(), 1);

        var element = source.Take(1);

        var haveNots = SubSetsOf(source.Skip(1));

        var haves = haveNots.Select(set => element.Concat(set));

        return haves.Concat(haveNots);
    }
}
