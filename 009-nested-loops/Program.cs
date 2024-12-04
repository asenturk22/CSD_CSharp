namespace _009_nested_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Sinif calismasi : Klavyeden bir sayi giriniz. Sifirdan baslayarak her satirda 
             * bes tane olacak bicimde aralarina bosluk birakarak sayilari yazdiriniz. Ornegin
             * Bir sayi giriniz : 9
             * 0 1 2 3 4
             * 5 6 7 8 9  gibi
             */

            System.Console.WriteLine("Bir sayi giriniz : ");
            int n = int.Parse(System.Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                System.Console.Write("{0}", i);
                if (i % 5 == 4)
                    System.Console.WriteLine();
                else
                    System.Console.Write(" ");
            }
            System.Console.WriteLine();
        }
    }
}
