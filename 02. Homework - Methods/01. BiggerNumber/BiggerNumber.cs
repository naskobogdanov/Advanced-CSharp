using System;

class BiggerNumber
{
    //This program will show is which of two numbers is grater!
    static int GetMax(int x, int y)
    {        
        int maxNum = x > y ? x : y;
        return maxNum;
    }

    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the seciond number: ");
        int secondNum = int.Parse(Console.ReadLine());

        int max = GetMax(firstNum, secondNum);
        Console.WriteLine("The grater number is: {0}", max);
    }
}