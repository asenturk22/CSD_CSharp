using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Input_keyboard
{
    class App
    {
        public static void Main()
        {
            int val;
            System.Console.Write("Bir deger giriniz:");
            val = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(val * val);
            System.Console.WriteLine("************************************************");

            /* Sınıf Çalışması: a, b, ve c isimli double türden 3 değişken bildiriniz. 
             * Sonra a ve b için klavyeden değer okuyunuz. Sonra da bunları çarparak 
             * sonucu c'ye atayınız ve c'yi yazdırınız.             
             */

            int a, b, c;
            System.Console.Write("a degerini giriniz: ");
            a = int.Parse(System.Console.ReadLine());
            System.Console.Write("b degerini giriniz: ");
            b = int.Parse(System.Console.ReadLine());
            c = a * b;
            System.Console.WriteLine("Sonuc : {0}", c);
            System.Console.WriteLine("************************************************");


            /* Sınıf Çalışması: Sample sınıfının içerisinde Square isimli bir metot yazınız.
             * Metodun geri dönüş değeri double türden olsun. Metot içerisinde klavyeden bir double
             * bir değer isteyiniz ve o double değerin karesiyle metodu geri döndürünüz.
             * Sonra Main metodundan Square metodunu çağırıp geri dönüş değerini yazdırınız.
             */

            double result;

            result = Sample.Square(); 
            System.Console.WriteLine(result);
            System.Console.WriteLine("************************************************");

            /* Karakter islemleri   */
            char ch = 'a';
            int r;

            r = ch + 1; 
            System.Console.WriteLine(r);
            System.Console.WriteLine("************************************************");

            /*
             * '\a' ---> alert (yazdırılmaya çalışılırsa ses çıkar)
             * '\b' ---> back space (yazdırılmaya çalışılırsa imleç sola gider ve soldaki karakter silinir)
             * '\f' ---> form feed (yazdırılmaya çalışılırsa imleç bir sayfa atlar)
             * '\n' ---> new line (yazdırılmaya çalışılırsa imleç aşağı satırın başına geçer)
             * '\r' ---> carriage return (yazdırılmaya çalışılırsa imleç bulunduğu satırın başına geçer)
             * '\t' ---> tab (yazdırılmaya çalışılırsa imleç bir tab atar)
             * ‘\v’ ---> vertical tab (düşey tab işlemi yapar)
             */

            System.Console.WriteLine("ali\nveli\tselami");


        }
    }

    class Sample
    {
        public static double Square ()
        {
            double val; 
            System.Console.Write ("Bir deger giriniz : ");
            val = double.Parse(System.Console.ReadLine());
            return val * val; 
        }
    }
}

