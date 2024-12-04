using System.ComponentModel;

namespace _008_sinif_calismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Klavyeden bir sayi giriniz. Onun asal carpanlarini asagidaki gibi ekrana yazdiriniz.
            // Lutfen bir sayi giriniz : 20 
            // 2 2 5

            int i = 2;
            int n;

            System.Console.WriteLine("Lutfen bir sayi giriniz: ");
            n = int.Parse(System.Console.ReadLine());

            while (n != 1)
            {
                if (n % i == 0) { 
                    System.Console.Write("{0} ", i);
                    n /= i;
                }
                else
                    ++i;
            }


            #endregion

            #region asallik testi yapan method

            System.Console.Write("Bir sayi giriniz : ");
            n = int.Parse(System.Console.ReadLine());

            for (i = 2; i <= n; ++i)
                if (Prime.IsPrime(i))
                    System.Console.Write("{0} ", i);

            System.Console.WriteLine();
            #endregion
        }
    }

    class Prime
    {
        public static bool IsPrime(int n)
        {
            /*
            for (int i = 2; i < n; ++i)
            {
                if (n % i == 0)
                    return false; 
            }

            return true;
            */

            if (n % 2 == 0)
                return n == 2;   // n = 2 ise true degilse false döndur

            for (int i = 3; i * i <= n; i += 2)
                if (n % i == 0)
                    return false;
            return true;


        }
    }
}
