using System;
using System.IO;

namespace _052_FileReadAllText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s;

                s = File.ReadAllText(@"..\..\..\Program.cs");
                Console.WriteLine(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
