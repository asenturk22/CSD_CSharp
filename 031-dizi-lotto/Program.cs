namespace _031_dizi_lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lotto lotto = new Lotto();
            int[] column;
            column = lotto.GetRandomColumn();
            Lotto.Disp(column);
        }
    }

    class Lotto
    {
        public Random rand;

        public Lotto()
        {
            rand = new Random();    
        }

        public int[] GetRandomColumn()
        {
            int[] column = new int[6];
            int val;
            bool repeat;

            for (int k = 0; k < 6; ++k)
            {
                do
                {
                    repeat = false;
                    val = rand.Next(1, 50);
                    for (int i = 0; i < k; ++i)
                    {
                        if (column[i] == val)
                        {
                            repeat = true;
                            break;
                        }
                    }
                } while (repeat);
                column[k] = val;
            }

            return column;
        }

        public static void Disp(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
    }
}
