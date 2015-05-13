using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSequence
{
    static void Main()
    {
        int[] intNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        List<List<int>> intList = new List<List<int>>();
        List<int> sublist = new List<int>();
        int currentCount = 0;
        int position = 0;

        for (int i = 0; i < intNums.Length - 1; i++)
        {                       
            if (i == 0)
            {
                sublist.Add(intNums[i]);
            }                
            if (intNums[i] >= intNums[i + 1])
            {
                intList.Add(sublist);
                sublist = new List<int>();
                sublist.Add(intNums[i + 1]);              
            }
            else
            {
                sublist.Add(intNums[i + 1]);
            }
        }
        intList.Add(sublist);
        Console.WriteLine(); 
       
        for (int i = 0; i < intList.Count; i++)
        {
            for (int j = 0; j < intList[i].Count; j++)
			{                
			    Console.Write(intList[i][j]);
                Console.Write(' ');
			}
            Console.WriteLine();
            if (intList[i].Count > currentCount)
            {
                currentCount = intList[i].Count;
                position = i;
            }
        }            
        
        Console.Write("Longest: ");
        foreach (var item in intList[position])
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}