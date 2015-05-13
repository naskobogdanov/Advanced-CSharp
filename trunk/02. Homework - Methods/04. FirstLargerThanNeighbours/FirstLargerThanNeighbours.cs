using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static bool FirstLargerThanNeighboursNum(int[] nums, int n)
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
        if (n == nums.Length - 1)
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
        if (nums[n] > nums[n + 1] && nums[n] > nums[n - 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static int NumbersCount(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (FirstLargerThanNeighboursNum(nums, i) == true)
            {                
                return nums[i];
            }         
        }
        return -1;
    }

    static void Main()
    {
        Console.WriteLine("Enter all ne numbers on a single line separated by space: ");
        int[] intNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine("The largest number in the array is: {0}", NumbersCount(intNums));
    }
}