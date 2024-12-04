namespace _034_Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                    Jagged Array - Dizileri tutan dizi

                    Burda int türünden 3 adet her biri farklı uzunluktaki dizilerin adresleirni 
                    tutan dizi tanımlıyoruz. 
             
             */

            int[][] a;

            a = new int[3][];

            a[0] = new int[] { 1, 2, };
            a[1] = new int[] { 4, 6 };
            a[2] = new int[] { 8, 9, 4 };

            for (int i = 0; i < a.Length; ++i)
            {
                for (int k = 0; k < a[i].Length; ++k)
                {
                    Console.Write("{0} ", a[i][k]);
                }
                Console.WriteLine();
            }
        }
    }
}
