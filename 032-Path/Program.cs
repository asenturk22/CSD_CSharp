using System;
using System.IO;


namespace _032_Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\windows\system32\a.dll";
            string result;

            //Dosya ismi ve uzantısı dahil
            result = Path.GetFileName(path);
            Console.WriteLine(result);

            //Dosya uzantısı "." dahil
            result = Path.GetExtension(path);
            Console.WriteLine(result);

            //Dizin yolu
            result = Path.GetDirectoryName(path);
            Console.WriteLine(result);
        }
    }
}
