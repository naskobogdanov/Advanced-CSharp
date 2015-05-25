using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        StreamReader oddLineReader = new StreamReader("read.txt");
        using (oddLineReader)
        {
            int lineNumber = 0;
            string line = oddLineReader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                }
                lineNumber++;                
                line = oddLineReader.ReadLine();
            }
        }
    }
}