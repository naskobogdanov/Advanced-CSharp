using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordCount
{
    static void Main()
    {
        using (var wordReader = new StreamReader("../../words.txt"))
        {
            using (var textReader = new StreamReader("../../text.txt"))
            {
                using (var writer = new StreamWriter("../../result.txt"))
                {
                    var words = new List<string>();
                    var word = wordReader.ReadLine().ToLower();
                    while (word != null)
                    {
                        words.Add(word);
                        word = wordReader.ReadLine();
                    }

                    string line = textReader.ReadLine();
                    var text = new List<string>();  
              
                    while (line != null)
                    {
                        string[] lineWords = line.ToLower().Split(' ', '.', ',' ,'-' , '?', '!');
                        for (int i = 0; i < lineWords.Length; i++)
                        {
                            text.Add(lineWords[i]);
                        }
                        line = textReader.ReadLine();
                    }

                    int counter = 0;
                    var result = new SortedDictionary<int, string>();
                    for (int i = 0; i < words.Count; i++)
                    {
                        for (int j = 0; j < text.Count; j++)
                        {
                            if (words[i] == text[j])
                            {                               
                                counter++;
                            }                            
                        }
                        result.Add(counter, words[i]);
                        counter = 0;
                    }
                    
                    foreach (var item in result.Reverse())
                    {
                        writer.WriteLine("{0} - {1}", item.Value, item.Key);
                    }
                    Console.WriteLine("Word count done!");
                } 
            }            
        }
    }
}