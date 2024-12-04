using System.Diagnostics;

namespace _020_Methodlarin_referans_parametreleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date();
            d.day = 1;
            d.month = 1;
            d.year = 2000;

            Foo(d);
            System.Console.WriteLine("{0}/{1}/{2}", d.day, d.month, d.year);


            Date date = GetDate();
            System.Console.WriteLine("{0}/{1}/{2}", date.day, date.month, date.year);

        }

        //methodun parametresi sinif türünden referanstir. 
        public static void Foo(Date k)
        {
            System.Console.WriteLine("{0}/{1}/{2}", k.day, k.month, k.year);

            k.day = 10;
            k.month = 10;
            k.year = 2015;
        }

        //methodun geri dönüş değeri sinif türünden referasntir. 
        public static Date GetDate()
        {
            Date d = new Date();

            d.day = 6;
            d.month = 6;
            d.year = 2024;

            return d;
        }
    }

    public class Date
    {
        public int day, month, year;
    }
}
