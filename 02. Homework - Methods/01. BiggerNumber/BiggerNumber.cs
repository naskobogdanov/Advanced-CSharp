using System;

class BiggerNumber
{
    //This program will show which of thr two numbers is grater!
    //Правим тестове с конфликти 
    //Това е тест от втория юзър    static int GetMax(int x, int y)
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