using System;
using System.Linq;

class SortArrayOfNumbersUsingSelectionSort
{
    static void Main()
    {
        int[] intNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        for (int i = 0; i < intNums.Length - 1; i++)
        {
            for (int j = i + 1; j < intNums.Length; j++)
            {
                if (intNums[i] > intNums[j])
                {
                    int temp = intNums[i];
                    intNums[i] = intNums[j];
                    intNums[j] = temp;
                }
            }            
        }
        foreach (var item in intNums)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}