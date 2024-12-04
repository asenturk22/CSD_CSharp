using System;
using System.IO;

namespace _032_Path_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] files;

            files = Directory.GetFiles(@"c:\windows");
            for (int i = 0; i < files.Length; ++i) 
                if (Path.GetExtension(files[i]).ToLower() == ".exe")
                    Console.WriteLine(Path.GetFileName(files[i]));
        }
    }
}
