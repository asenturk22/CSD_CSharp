namespace _031_diziler_bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Sort.BubbleSort(a);
            Sort.Disp(a);
        }
    }

    class Sort
    {
        public static void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
                for (int k = 0; k < a.Length - 1 - i; k++)
                {
                    if (a[k] > a[k + 1])
                    {
                        int temp = a[k];
                        a[k] = a[k + 1];
                        a[k + 1] = temp;
                    }
                }
        }

        public static void Disp(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }

            Console.WriteLine();
        }
    }
}
