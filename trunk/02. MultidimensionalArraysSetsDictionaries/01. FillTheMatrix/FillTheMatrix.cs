using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter the size N of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;

        //Matrix One
        int[,] matrixOne = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrixOne[j, i] = counter;
                counter++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Matrix pattern A:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0 , 3}", matrixOne[i, j]);
            }
            Console.WriteLine();
        }


        //Matrix Two
        counter = 0;
        bool direction = true;
        Console.WriteLine();
        int[,] matrixTwo = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (counter % n == 0)
                {
                    direction = !direction;
                    counter = counter + n;
                }
                                
                if (direction == true)
                {
                    counter++; 
                    matrixTwo[j, i] = counter;
                                       
                }
                else
                {
                    counter--;
                    matrixTwo[j, i] = counter + 1;                                        
                }   
            }            
        }

        Console.WriteLine("Matrix pattern B:");
        for (int i = n - 1 ; i >= 0; i--)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0 , 3}", matrixTwo[i, j]);                
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}