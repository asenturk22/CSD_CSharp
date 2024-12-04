namespace _025_lastIndexOf_sinif_calismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Sınıf Çalışması: Klavyeden mutlak bir bir yol ifadesi (absolute path) isteyiniz. Yol ifadesindeki dosya
ismini (uzantı dahil değil) yazdırınız. Örneğin “c:\windows\temp\a.dat” gibi bir girişte a'nın yazdırılması
gerekir. Yol ifadesindeki dosyanın uzantısı olmak zorunda değildir ve Windows sistemlerinde dosya
isminde birden fazla '.' karakteri bulunabilir. Bu durumda uzantı son '.' karakterinin sağındaki karakterlerdne
oluşmaktadır.
             */

            string path, fileName;
            int index;

            System.Console.Write("Bir yol ifades (path) giriniz : ");
            path = System.Console.ReadLine();
            if ((index = path.LastIndexOf('\\')) == -1)
            {
                System.Console.WriteLine("Girilen yol ifadesi geçerli değil!");
                return;
            }

            fileName = path.Substring(index + 1);
            System.Console.WriteLine(fileName);

            if ((index = fileName.LastIndexOf('.')) != -1) 
                fileName = fileName.Substring(0, index);

            System.Console.WriteLine(fileName);

        }
    }
}
