namespace _031_031_diziler_selection_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Sort.SelectionSort(a);
            Sort.Disp(a);
        }
    }

    class Sort
    {
        public static void SelectionSort(int[] a)
        {
            int min, minIndex;

            for (int i = 0; i < a.Length - 1; i++)
            {
                min = a[i];
                minIndex = i;

                for (int k = i + 1; k < a.Length; ++k)
                    if (a[k] < min)
                    {
                        min = a[k];
                        minIndex = k;
                    }

                a[minIndex] = a[i];
                a[i] = min;
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
