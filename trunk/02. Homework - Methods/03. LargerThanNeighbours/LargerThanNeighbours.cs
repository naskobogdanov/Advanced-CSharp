using System;
using System.Linq;

class LargerThanNeighbours
{
    static bool IsLargerThanNeighbours(int[] nums, int n)
    {
        if (n == 0)
        {
            if (nums[n] > nums[n + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (n == nums.Length - 1)
        {
            if (nums[n] > nums[n - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (nums[n] > nums[n + 1] && nums[n] > nums[n - 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter all ne numbers on a single line separated by space: ");
        int[] intNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < intNums.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(intNums, i));
        }
    }
}