using System;

namespace _002_MathOp
{
    public class Program
    {
        static void Main(string[] args)
        {
            double result;

            result = MathOp.Add(10, 20);
            System.Console.WriteLine(result);
            result = MathOp.Mul(10, 20);
            System.Console.WriteLine(result);
            System.Console.WriteLine("---------------------------------------------------");


            #region Bazı Matematiksel Metotlar
            //System.Math isimli sinifin static metotlari bazi önemli matematiksel islemler yapmaktadir. 

            //Sqrt metodu : karekoku dondurur
            result = System.Math.Sqrt(25);
            System.Console.WriteLine(result);

            //Pow metodu : Us alma
            result = System.Math.Pow(2, 10);
            System.Console.WriteLine(result);

            //Sin, Cos, Tan, ASin, ACos, Atan : trigonometrik islemleri yapar. 
            double angle;

            System.Console.Write("Lutfen radyan cinsinden açı giriniz : ");
            if (double.TryParse(System.Console.ReadLine(), out angle))
            {
                result = System.Math.Pow(System.Math.Sin(angle), 2) + 
                         System.Math.Pow(System.Math.Cos(angle), 2);
                System.Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Geçersiz açı değeri.");
            }


            //Log metodu : e tabanina gore logaritma, Log10 metodu 10 tabanina gore logaritma hesaplar. 
            result = System.Math.Log10(1000);
            System.Console.WriteLine(result);

            System.Console.WriteLine("---------------------------------------------------");

            #endregion


            #region Sqrt kullanimina ornek

            double a, b, c;

            System.Console.Write("a: ");
            while (!double.TryParse(System.Console.ReadLine(), out a))
            {
                Console.WriteLine("Geçersiz giriş, lütfen bir sayı girin.");
            }

            System.Console.Write("b: ");
            while (!double.TryParse(System.Console.ReadLine(), out b))
            {
                Console.WriteLine("Geçersiz giriş, lütfen bir sayı girin.");
            }

            System.Console.Write("c: ");
            while (!double.TryParse(System.Console.ReadLine(), out c))
            {
                Console.WriteLine("Geçersiz giriş, lütfen bir sayı girin.");
            }

            Root.DispRoots(a, b, c);
            
            System.Console.WriteLine("---------------------------------------------------");

            #endregion
        }
    }

    public class Root
    {
        public static void DispRoots(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c; ;
            double x1, x2;

            System.Console.WriteLine($"delta : {delta}");
            
            if (delta < 0)
            {
                Console.WriteLine("Gerçek kök yok");
                return;
            }

            x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - System.Math.Sqrt(delta)) / (2 * a);

            System.Console.WriteLine($"Kökler : x1 = {x1}, x2 = {x2}");
        }
    }

    public class MathOp
    {
        public static double Add(int a, int b)
        {
            return a + b;
        }

        public static double Mul(int a, int b)
        {
            return a * b;
        }
    }
}
