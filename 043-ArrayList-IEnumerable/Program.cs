using System;
using System.Collections;

namespace _043_ArrayList_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            string name;

            for (; ; )
            {
                Console.Write("Adı Soyadı: ");
                name = Console.ReadLine();
                if (name == "exit")
                    break;

                al.Add(name);
            }

            foreach (object o in al)
            {
                string s = (string)o;
                Console.Write(s);
            }


            ArrayList _al = new ArrayList();

            for (int i = 0; i < 100; ++i)
            {
                Console.WriteLine("Count = {0}, Capacity = {1}", _al.Count, _al.Capacity);
                _al.Add(i);
            }
        }
    }
}
