namespace _009_sinif_calismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Sinif calismasi : Klavyeden int turden bir n sayisi okuyunuz. Asagidaki deseni cikartiniz. 
             * *
             * ** 
             * ***
             * **** (n tane)
             */

            int n;

            System.Console.WriteLine("Bir sayi giriniz : ");
            n = int.Parse(System.Console.ReadLine());

            for (int i = 0; i < n; i++)
            { 
                for (int k = 0; k <= i; k++)
                    System.Console.Write("*");
                System.Console.WriteLine();
            }

            /*
                Sınıf Çalışması: Klavyeden width ve height için iki int değer okuyunuz. 
                Aşağıdaki kutucuğu oluşturunuz:
                
             ******
                * *
                * *
                ******
             */

            int width, height;

            System.Console.WriteLine("Bir genişlk giriniz : ");
            width = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Bir yükseklik giriniz : ");
            height = int.Parse(System.Console.ReadLine());
            for (int i = 1; i <= height; ++i)
            {
                for (int k = 1; k <= width; ++k)
                {
                    if (k == 1 || k == width)
                        System.Console.Write("*");
                    else if (i == 1 || i == height)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();

            }

         /*
            Sınıf Çalışması: Klavyeden width ve height için iki int değer okuyunuz. 
            Aşağıdaki kutucuğu oluşturunuz:
               * 
              ***
             *****
            *******
         */
        System.Console.WriteLine("Bir sayi giriniz : ");
        n = int.Parse(System.Console.ReadLine());

        for (int i = 0; i  < n; ++i)
        {
            for (int k = 0; k < n - i - 1; ++k)
                System.Console.Write(" ");
            for (int k = 0; k < 2 * i + 1; ++k)
                System.Console.Write("*");
            System.Console.WriteLine();
        }

            /*
            Sınıf Çalışması: Rectangle isimli sınıfın içerisine ‘*’ karakterleriyle dikdörtgen basan 
            Disp isimli metodu aşağıdaki parametrik yapıya uygun olarak yazınız:

             public static void Disp(int row1, int col1, int ro2, int col2)

            Metot dikdörtgenin sol üst ve sağ alt koordinatlarını parametre olarak almaktadır.
            */

            System.Console.CursorVisible = false;
            Rectangle.Disp(30, 30, 50, 50);
            System.Console.ReadKey(true);


        }
    }

    public class Rectangle
    {
        public static void Disp(int row1, int col1, int row2, int col2)
        {
            for (int r = row1; r <= row2; ++r)
            {
                System.Console.SetCursorPosition(col1, r);
                System.Console.Write("*");
                for (int c = col1 + 1; c < col2; ++c)
                    System.Console.Write(r == row1 || r == row2 ? "*" : " ");
                System.Console.Write("*");
            }
        }
    }
}
