using System;
using System.Collections;

namespace _051_IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add(new A());
            al.Add(new B());
            al.Add(new C());
            al.Add(new B());
            al.Add(new B());
            // ...

            foreach (IDisposable id in al)
            {
                id.Dispose();
            }
        }
    }

    class A : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("A Dispose ediliyor.");
        }
    }

    class B : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("B Dispose ediliyor.");
        }
    }

    class C : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("C Dispose ediliyor.");
        }
    }
}
