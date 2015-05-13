using System;
using System.Linq;

class NumberCalculations
{
    static decimal Minimum(decimal[] nums)
    {
        int position = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                {
                    position = i;
                    break;
                }
                break;
            }                 
        }
        return nums[position];
    }

    static double Minimum(double[] nums)
    {
        int position = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                {
                    position = i;
                    break;
                }
                break;
            }
        }
        return nums[position];
    }

    static decimal Maximum(decimal[] nums)
    {
        int position = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    position = i;
                    break;
                }
                break;
            }
        }
        return nums[position];
    }

    static double Maximum(double[] nums)
    {
        int position = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    position = i;
                    break;
                }
                break;
            }
        }
        return nums[position];
    }

    static decimal Average(decimal[] nums)
    {
        decimal sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum/nums.Length;
    }

    static double Average(double[] nums)
    {
        double sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum / nums.Length;
    }

    static decimal Sum(decimal[] nums)
    {
        decimal sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

    static double Sum(double[] nums)
    {
        double sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

    static decimal Product(decimal[] nums)
    {
        decimal product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
        }
        return product;
    }

    static double Product(double[] nums)
    {
        double product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine("Please enter your numbers on a single line separated by space: ");
        decimal[] nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        //If you want to use is with doubles, just remove the comment below and put a comment on the row above
        //double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        Console.WriteLine("Min: {0}", Minimum(nums));
        Console.WriteLine("Max: {0}", Maximum(nums));
        Console.WriteLine("Average: {0:F2}", Average(nums));
        Console.WriteLine("Sum: {0}", Sum(nums));
        Console.WriteLine("Product: {0}", Product(nums));
    }
}