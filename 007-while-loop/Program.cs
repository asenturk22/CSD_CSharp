namespace _007_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kontrolun basta yapildigi while loop
            // while (<bool turden ifade>) 
            //      <deyim>

            int i = 0;                  // bildirim deyimi
                
            while (i < 10 )             // bilesik deyim start
            {
                System.Console.WriteLine(i);
                ++i;
            }                           // bilesik deyim end
            System.Console.WriteLine("Donguden sonra i = {0}", i);


            while (i >= 0)
            {
                System.Console.WriteLine(i);
                --i;
            }
            System.Console.WriteLine("Donguden sonra i = {0}", i);

            #endregion

            #region Sinif Calismasi 
            /*
             * Sınıf Çalışması: Tek bir while döngüsü kullanarak 0'dan 99'a kadar (99 dahil) sayıları
             * her satırda 5 sayı olacak biçimde aşağıdaki gbi yazdırınız:
             * 0 1 2 3 4
             * 5 6 7 8 9
             * ....
             * 95 96 97 98 99
             */

            int x = 0; 

            while (x < 100)
            {
                if (x % 5 == 0)
                    System.Console.WriteLine("");

                System.Console.Write("{0} ", x);
                x++;
            }
            #endregion

            #region Sinif Calismasi 
            /* Önce klavyeden bir n sayısı isteyiniz. Sonra while döngüsünü kullanarak
             * klavyeden int türden n tane sayı isteyip bunların toplamını yazdırınız. 
             */


            System.Console.Write("\n n degeri giriniz: ");
            int n = int.Parse(System.Console.ReadLine());
            int total = 0;
            i = 1;

            while (n > 0)
            {
                System.Console.Write("{0}. sayiyi giriniz: ", i++);
                
                total += int.Parse(System.Console.ReadLine());
                n--;
            }

            System.Console.WriteLine("Girilen degerlerin toplam : {0} ", total);


            #endregion

            #region 

            i = 0; 

            while (++i < 10)
            {
                System.Console.Write("{0}", i);
            }

            System.Console.WriteLine("");

            #endregion

            #region 

            i = 0;

            while (i++ < 10)
            {
                System.Console.Write("{0}", i);
            }

            System.Console.WriteLine("");

            #endregion

            #region 

            i = 0;

            while (++i < 1000000)  //gecikme olusturur
                ;  

            System.Console.WriteLine("Son");
            System.Console.WriteLine("");

            #endregion

            #region  do - while loop
            i = 0;

            do
            {
                System.Console.WriteLine(i);
                ++i;
            } while (i < 10);
            #endregion

            #region  do - while loop

            // ToLower(char c)
            // ToUpper(char c)
            // ch = char.ToLower(char.Parse(System.Console.ReadLine()))

            char ch;

            do
            {
                System.Console.Write("(e)vet/(h)ayır? : ");
                ch = char.Parse(System.Console.ReadLine());
            } while (ch != 'e' && ch != 'h' && ch != 'H' && ch != 'E');

            if (ch == 'e' || ch == 'E')
                System.Console.WriteLine("Evet");
            else
                System.Console.WriteLine("Hayir");


            #endregion

        }


    }
}
