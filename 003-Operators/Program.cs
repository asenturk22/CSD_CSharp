namespace _003_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* |----------------|------------------|
             * |  ()            | soldan saga      |
             * |----------------|------------------|
             * |  +  -          | sağdan sola      |  isaret operatörleri
             * |  ++ --         |                  |  arttirma, eksiltme operatorleri
             * |  !             |                  |
             * |----------------|------------------|
             * |  *  /  %       | soldan saga      |   
             * |----------------|------------------|
             * |  +  -          | soldan saga      | 
             * |----------------|------------------|
             * |  >  < >=  <=   | soldan saga      |
             * |----------------|------------------|
             * |  ==  !=        | soldan saga      |
             * |----------------|------------------|
             * |  &&            | soldan saga      |
             * |----------------|------------------|
             * |  ||            | soldan saga      |
             * |----------------|------------------|
             * |  =, +=, -=,    | sagdan sola      |
             * |  *=, /=, %=    |                  |
             * |----------------|------------------|
             */

            #region % operatörü
            int result;

            result = 20 % 3;
            System.Console.WriteLine(result);
            #endregion

            #region Sinif Calismasi
            /* Klavyeden int türden pozitif bir sayı isteyiniz.
             * Sayının kendisine en yakın fakat ondan küçük eşit olan 4'ün katını yazdırınız
             *  Örneğin 15 için 12, 9 için 8, 6 için 4, 8 için 8 yazdırılmalıdır
             */

            int val; 

            while (!int.TryParse(System.Console.ReadLine(), out val)) {
                System.Console.WriteLine("Geçersiz bir giriş, lütfen sayi giriniz :  ");
            }

            result = val - val % 4;
            System.Console.WriteLine(result);

            /* Yukaridaki islem onceligine göre once (val % 4) islemi yapilacak ardindan
             * val degerinden cikarma islemi gerceklestirilecektir. 
             */

            #endregion

            #region Sinif Calismasi

            /* : Klavyeden pozitif bir int değer okuyunuz.
             *  Bu değerden büyük ya da eşit olan dördün katını yazdırınız
             *  Örneğin 15 için 16, 8 için 8, 10 için 12 yazdırmalısınız. 
             */

            while (!int.TryParse(System.Console.ReadLine(), out val))
            {
                System.Console.WriteLine("Geçersiz bir giriş, lütfen sayi giriniz :  ");
            }

            result = (val + 3) - (val + 3) % 4;
            System.Console.WriteLine(result);

            #endregion

            #region ++ ve -- operatorleri

            int a = 10;
            --a;
            System.Console.WriteLine(a);            // 9

            a++;
            System.Console.WriteLine(a);            // 10


            #endregion

            #region Karsilastirma Operatorleri
            // <, >, <=, >=, ==, !=
            bool b_result; 

            System.Console.Write("Bir sayi giriniz: ");
            val = int.Parse(System.Console.ReadLine());

            b_result = val % 2 == 0;
            System.Console.WriteLine(b_result);


            #endregion

            #region Mantiksal Operatorler
            /*
             *  !   (NOT)
             *  &&  (AND)
             *  ||  (OR)
             */

            b_result = val >= 10 && val <= 20;
            System.Console.WriteLine(result);
            #endregion
        }
    }
}
