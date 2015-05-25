using System;
using System.IO;

class CopyBinaryFile
{
    static void Main()
    {
        using (var source = new FileStream("../../image.jpg", FileMode.Open))
        {
            using (var destination = new FileStream("../../copy_of_image.jpg", FileMode.Create))
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    destination.Write(buffer, 0, readBytes);
                }
                Console.WriteLine("Your file is copyed!");
            }
        }
    }
}