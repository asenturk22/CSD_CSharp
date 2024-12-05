using System;
using System.IO;

namespace _052_FileCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                File.Copy(@"c:\windows\notepad.exe", "notepad.exe");
                Console.WriteLine("Başarılı...");
            }
            catch (Exception e)  
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                File.Delete("notepad.exe");
                Console.WriteLine("Dosya silindi.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
