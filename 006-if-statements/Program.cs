using System.ComponentModel.Design.Serialization;

namespace _006_if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 
            int x;

            System.Console.Write("Bir deger giriniz:");
            x = int.Parse(System.Console.ReadLine());

            if (x > 0)
                System.Console.WriteLine("Pozitif");
            else
                System.Console.WriteLine("Negatif");

            System.Console.WriteLine("Son");
            #endregion

            #region
            double a, b, c;

            System.Console.Write("a: ");
            a = double.Parse(System.Console.ReadLine());
            System.Console.Write("b: ");
            b = double.Parse(System.Console.ReadLine());
            System.Console.Write("c: ");
            c = double.Parse(System.Console.ReadLine());

            Root.DispRoots(a, b, c);

            #endregion
        }
    }

    class Root
    {
        public static void  DispRoots (double a, double b, double c)
        {
            double delta;
            double x1, x2;

            delta = b * b - 4 * a * c;
            if (delta >= 0)
            {
                x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - System.Math.Sqrt(delta)) / (2 * a);

                System.Console.WriteLine(x1);
                System.Console.WriteLine(x2);
            }
            else
                System.Console.WriteLine("Gercek kok yok");
        }
    }
}

