using System;

namespace _052_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  .   o andaki dizini
            // ..   o andaki dizinin bir üst dizinini ifade eder. 
            // NET'in tüm dosya sınıfları System.IO isim alanı içerisinde ya da
            // bu isim alanın içindeki isim alanları içerisindedir

            Console.WriteLine(Environment.CurrentDirectory);
            Environment.CurrentDirectory = @"c:\windows";
            Console.WriteLine(Environment.CurrentDirectory);
        }
    }
}
