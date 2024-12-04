using System;
using System.Collections;

namespace _043_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                al.Add(i * i);   
            }

            for (int i = 0; i < al.Count; i++)
            {
                int val = (int)al[i];
                Console.Write("{0} ", val);
            }

            Console.WriteLine();    

            ArrayList names = new ArrayList();
            string name;

            for(;;) 
            {
                Console.Write("Bir isim giriniz");
                name = Console.ReadLine();
                if (name == "exit")
                    break;

                names.Add(name);
            }

            for (int i = 0; i < names.Count; i++)
            {
                if (i != 0)
                    Console.Write(", ");
                name = (string)names[i];
                Console.Write(name);
            }

            Console.WriteLine();
        }
    }
}
