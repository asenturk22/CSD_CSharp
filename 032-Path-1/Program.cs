using System;
using System.IO;

namespace _032_Path_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] files;

            files = Directory.GetFiles(@"c:\windows");
            for (int i = 0; i < files.Length; ++i)
            {
                Console.WriteLine(Path.GetFileName(files[i]));
            }
        }
    }
}
