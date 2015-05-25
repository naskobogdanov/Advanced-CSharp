using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class DirectoryTraversal
{
    static void Main()
    {
        string[] filePaths = Directory.GetFiles(@"../../");
        List<FileInfo> files = filePaths.Select(path => new FileInfo(path)).ToList();
        var sorted = files.OrderBy(file => file.Length).GroupBy(file => file.Extension).OrderByDescending(group => group.Count()).ThenBy(group => group.Key);
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        
        using (var writer = new StreamWriter(desktop + "/report.txt"))
        {
            foreach (var item in sorted)
            {
                writer.WriteLine(item.Key);
                foreach (var output in item)
                {
                    writer.WriteLine("--{0} - {1:F3}kb", output.Name, output.Length / 1024.0);
                }
            }    
        }
        Console.WriteLine("All operations are done!");
    }
}