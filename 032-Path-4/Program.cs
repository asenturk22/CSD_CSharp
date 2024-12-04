using System;

namespace _032_Path_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val;
            string result;

            for (; ; )
            {
                Console.Write("Bir sayı giriniz: ");
                val = int.Parse(Console.ReadLine());

                result = Number.ToText(val);
                Console.WriteLine(result);
                if (val == 0)
                    break;
            }
        }
    }

    public class Number
    {
        public static string ToText(int val) 
        {
            string[] ones = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] tens = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş",
"seksen", "doksan" };

            int one, ten, hundred;

            string result = "";

            hundred = val / 100;
            ten = val / 10 % 10;
            one = val % 10;

            if (val == 0)
                return "sıfır";

            if (hundred > 0)
            {
                if (hundred != 1)
                {
                    result += ones[hundred] + " ";
                }

                result += "yüz";

                if (ten > 0 || one > 0)
                    result += " ";
            }

            if (ten > 0)
            {
                result += tens[ten];
                if (one > 0)
                    result += " ";
            }

            if (one > 0)
            {
                result += ones[one];
            }

            return result;
        }
    }
}
