namespace _024_IndexOf_sinif_calismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Sınıf Çalışması: Klavyeden bir yazı isteyiniz. Yazının içerisinde küme parantezleri arasında bir kısım olsun.
Küme parantezlerinin yerini IndexOf metotlarıyla bulunuz. Onun arasındaki yazıyı Substring metoduyla
elde edip yazdırınız. Örneğin:

            Bir yazı giriniz: bugün {hava} çok güzel
            hava
             */

            string text, m;
            int indexBeg, indexEnd; 

            System.Console.WriteLine("Bir yazı giriniz: ");
            text = Console.ReadLine();

            
            if ((indexBeg = text.IndexOf("{")) == 1)
            {
                Console.WriteLine("Yanlış giriş!");
                return;
            }

            if ((indexEnd = text.IndexOf("}")) == 1)
            {
                Console.WriteLine("Yanlış giriş!");
                return;
            }

            if (indexBeg >= indexEnd)
            {
                Console.WriteLine("Yanlış giriş!");
                return;
            }

            string result = text.Substring(indexBeg + 1, indexEnd - indexBeg -1);
            Console.WriteLine(result);
        }
    }
}
