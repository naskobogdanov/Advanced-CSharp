using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {

        int counter = 0;
        using (var reader = new StreamReader("../../text.txt"))
        {
            using (var writer = new StreamWriter("../../numberedLineText.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.Write("{0} ",counter);
                    for (int i = 0; i < line.Length; i++)
                    {
                        writer.Write(line[i]);
                    }

                    writer.WriteLine();
                    line = reader.ReadLine();
                    counter++;
                }
            }
        }
    }
}