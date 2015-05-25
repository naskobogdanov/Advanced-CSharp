using System;
using System.Collections.Generic;
using System.IO;

class SlicingFile
{
    static void Main()
    {
        string sourceFile = "../../text.txt";
        string destinationDirectory = "../../";
        int parts = 5;
        Slice(sourceFile, destinationDirectory, parts);
        List<string> files = new List<string> {  
                                "../../Part-0.txt",
                                "../../Part-1.txt",
                                "../../Part-2.txt",
                                "../../Part-3.txt",
                                "../../Part-4.txt",
                             };

        Assemble(files, destinationDirectory);
        Console.WriteLine("All tasks are done!");
    }

    static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        FileInfo fileInfo = new FileInfo(sourceFile);

        int size = (int)fileInfo.Length;
        int partSize = size / parts;
        int lastPartSize = size - (parts - 1) * partSize;

        string name = fileInfo.Name;
        string[] nameExtArr = name.Split('.');

        using (var source = new FileStream(sourceFile, FileMode.Open))
        {
            source.Seek(0, SeekOrigin.Current);
            for (int i = 0; i < parts; i++)
            {
                int currentSize = (i == (parts - 1)) ? lastPartSize : partSize;
                byte[] buffer = new byte[currentSize];
                source.Read(buffer, 0, currentSize);
                string currentFilePath = destinationDirectory + "Part-" + i + "." + nameExtArr[1];
                using (FileStream dest = new FileStream(currentFilePath, FileMode.Create))
                {
                    dest.Write(buffer, 0, currentSize);
                }   
            }
        }
    }

    private static void Assemble(List<string> files, string destinationDirectory)
    {
        string ext = files[0].Substring(files[0].LastIndexOf('.'));
        string destinationFile = destinationDirectory + "assembled" + ext;
        using (FileStream dest = new FileStream(destinationFile, FileMode.Append, FileAccess.Write))
        {
            foreach (string inFile in files)
            {
                using (FileStream source = new FileStream(inFile, FileMode.Open))
                {
                    byte[] buffer = new byte[4096];
                    int len;
                    while ((len = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        dest.Write(buffer, 0, len);
                    }                       
                }
            }
        }
    }
}