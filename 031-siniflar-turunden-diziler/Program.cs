namespace _031_siniflar_turunden_diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample[] ss = new Sample[5];

            // RAM'deki dizilim:
            /*
                 ss[0] -> null
                 ss[1] -> null
                 ss[2] -> null
                 ss[3] -> null
                 ss[4] -> null
            */

            for (int i = 0; i < 5; i++)
            {
                ss[i] = new Sample(i);  //Dizinin her bir elemanina yeni yaratilan Sample nesnesinin adresini ata
            }

            for (int i = 0; i < 5; i++)
            {
                ss[i].Disp();
            }

            Console.WriteLine();

            //Sinif dizilerinde ilk değer verme
            Sample[] ss2;

            ss2 = new Sample[] { new Sample(10), new Sample(20), new Sample(30) };
            for (int i = 0; i < ss2.Length; ++i)
                ss2[i].Disp();

            Console.WriteLine();

            //İki tırnak içerisindeki yazılar birer string referansı belirttiğine göre biz bunları bir string dizisinin
            //elemanlarına atayabiliriz. Örneğin:
            string[] names = new string[5];

            names[0] = "ali";
            names[1] = "veli";
            names[2] = "selami";
            names[3] = "ayşe";
            names[4] = "fatma";

            for (int i = 0; i < names.Length; ++i)
                Console.WriteLine(names[i]);
        }
    }

    class Sample
    {
        public int val;

        public Sample(int v)
        {
            val = v;
        }

        public void Disp()
        {
            Console.WriteLine(val);
        }
    }
}
