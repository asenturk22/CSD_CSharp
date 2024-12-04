using System;

namespace _032_Path_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val;

            string[] ones = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] tens = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

            Console.WriteLine("En fazla iki basamaklı pozitif bir sayı giriniz : ");
            val = int.Parse(Console.ReadLine());

            if (val < 0 || val >= 100)
            {
                Console.WriteLine("Giriş doğru değil!");
                return;
            }

            if (val == 0)
            {
                Console.WriteLine("sıfır");
                return;
            }

            if (val > 9)
            {
                Console.WriteLine(" ");
            }

            Console.WriteLine(ones[val % 10]);
        }
    }
}
