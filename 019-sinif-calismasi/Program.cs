namespace _019_sinif_calismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              System.Console.ReadKey(true).KeyChar ifadesini kullanarak tuşa her basıldığında ekrana 
              "Ali", "Veli", "Selami", "Ayşe", "Fatma" isimlerinden rastgele birini yazdıran 'q' 
              tuşuna basıldığında çıkan programı yazınız. 
            */

            System.Random r = new System.Random();
            int val = 0;

            while (System.Console.ReadKey(true).KeyChar != 'q')
            {
                val = r.Next(5);
                switch (val)
                {
                    case 0:
                        System.Console.WriteLine("Ali");
                        break;
                    case 1:
                        System.Console.WriteLine("Veli");
                        break;
                    case 2:
                        System.Console.WriteLine("Selami");
                        break;
                    case 3:
                        System.Console.WriteLine("Ayşe");
                        break;
                    case 4:
                        System.Console.WriteLine("Fatma");
                        break;
                }

            }

        }
    }
}
