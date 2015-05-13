using System;
using System.Linq;

class SortArrayOfNumbers
{
    static void Main()
    {
        int[] intNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Array.Sort(intNums);
        foreach (var item in intNums)
        {
            Console.Write("{0} ",item);
        }
    }
}