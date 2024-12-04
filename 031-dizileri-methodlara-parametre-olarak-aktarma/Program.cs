namespace _031_dizileri_methodlara_parametre_olarak_aktarma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 4, 3, 9, 10, 11, 12 };
            int max;

            MyArray.Disp(a);
            max = MyArray.GetMax(a);
            Console.WriteLine(max);

            //dizi yaratilirken methodlara parametre olarak verilebilir. 
            double result;
            result = MyArray.Avg(new int[] { 5, 4 });
            Console.WriteLine(result);

        }

        class MyArray
        {
            public static int GetMax(int[] a)
            {
                int max = a[0];

                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max)
                        max = a[i];

                return max;
            }

            public static void Disp(int[] a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write("{0} ", a[i]);
                }

                Console.WriteLine();
            }

            public static double Avg(int[] a)
            {
                int total = 0; 

                for (int i = 0; i < a.Length; i++)
                    total += a[i];

                return (double)total / a.Length;
            }
        }
    }
}
