using System.Diagnostics;

namespace _016_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            long b = 12;

            A.Foo(a);
            A.Foo(b);
            A.Foo(a, b);
            A.Foo(b, a);


            //Yeni nesnenin oluşturulması
            DateDisp date = new DateDisp();

            date.day = 1;
            date.month = 6;
            date.year = 1982;

            System.Console.WriteLine("{0}-{1}-{2}", date.day, date.month, date.year);

            //birden fazla DateDisp nesnesi oluşturalim.
            DateDisp date1, date2;

            date1 = new DateDisp();
            date2 = new DateDisp();

            date1.day = 5;
            date1.month = 9;
            date1.year = 1989;

            date2.day = 4;
            date2.month = 5;
            date2.year = 1995;

            System.Console.WriteLine("date1 nesnesinin degerleri : {0}-{1}-{2}", date1.day, date1.month, date1.year);
            System.Console.WriteLine("date2 nesnesinin degerleri : {0}-{1}-{2}", date2.day, date2.month, date2.year);

            //aynı türden referanslarin birbirine atanmasi 
            date2 = date1;

            System.Console.WriteLine("date1 nesnesinin degerleri : {0}-{1}-{2}", date1.day, date1.month, date1.year);
            System.Console.WriteLine("date2 nesnesinin degerleri : {0}-{1}-{2}", date2.day, date2.month, date2.year);
            //socun date2 degerleri olur. iki referans ta aynı adresi göstermektedir. 

            //static variables


        }
    }

    public class Sample
    {
        public int a;
        public int b;

        public void Set(int x, int y)
        {
            a = x;
            b = y; 
        }

        public void Disp()
        {
            System.Console.WriteLine("{0}, {1}", a, b);
        }
    }

    public class A 
    {
        public static void Foo(int a )
        {
            System.Console.WriteLine("int a");
        }

        //method overloading
        public static void Foo(long a)
        {
            //...
            System.Console.WriteLine("long a");

        }

        //method overloading
        public static void Foo(int a, long b)
        {
            //...
            System.Console.WriteLine("int a, long b");

        }

        //method overloading
        //methodun imzası farklı olduğu için hata yok. 
        //methodun imzası parametre dizilim şeklidir. 
        //burda    Foo long, int
        //yukarıda Foo int, long
        public static void Foo(long b, int a)
        {
            //...
            System.Console.WriteLine("long b, int a");

        }

    }

    public class B
    {
        public static void Foo(int a)
        {
            //...
        }
    }

    class DateDisp
    {
        public int day;
        public int month;
        public int year;
    }

}
