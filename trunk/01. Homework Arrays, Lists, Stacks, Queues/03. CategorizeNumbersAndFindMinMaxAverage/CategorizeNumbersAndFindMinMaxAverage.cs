using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumbersAndFindMinMaxAverage
{
    static void Main()
    {
        double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        List<int> intList = new List<int>();
        List<double> floatList = new List<double>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]%1 == 0)
            {
                intList.Add((int)nums[i]);
            }
            else
            {
                floatList.Add(nums[i]);
            }
        }

        Console.WriteLine();
        Console.Write("[{0}]", string.Join(", ", floatList));        
        Console.WriteLine(" -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}", floatList.Min(), floatList.Max(), floatList.Sum(), floatList.Average());
        Console.WriteLine();
        Console.Write("[{0}]", string.Join(", ", intList)); 
        Console.WriteLine(" -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}", intList.Min(), intList.Max(), intList.Sum(), intList.Average());
    }
}