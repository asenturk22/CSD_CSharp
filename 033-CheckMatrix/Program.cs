namespace _033_CheckMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[9, 9]
            {
                 { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                 { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                 { 1, 9, 8, 3, 4, 2, 5, 6, 7},
                 { 8, 5, 9, 7, 6, 1, 4, 5, 3 },
                 { 4, 2, 6, 8, 5, 3, 7, 9, 1},
                 { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                 { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                 { 2, 8, 7, 4, 1, 9, 6, 3, 5},
                 { 3, 4, 5, 2, 8, 6, 1, 7, 9 }
            };

            Console.WriteLine(CheckMatrix(a) ? "Geçerli" : "Geçersiz");

        }

        public static bool CheckMatrix(int[,] a)
        {
            int[] flags;

            // a adresindeki matrisin boyutları eşit değilse kare matris değildir false dön. 
            if (a.GetLength(0) != a.GetLength(1))
                return false;

            for (int row = 0; row < a.GetLength(0); ++row)
            {
                flags = new int[a.GetLength(0)];

                for (int col = 0; col < a.GetLength(0); ++col)
                {
                    if (a[row, col] < 1 || a[row, col] > a.GetLength(0))
                        return false;
                    if (flags[a[row, col] - 1] == 1)
                        return false;
                    flags[a[row, col] - 1] = 1;
                  
                }

                            
            }

            for (int col = 0; col < a.GetLength(0); ++col)
            {
                flags = new int[a.GetLength(0)];

                for (int row = 0; row < a.GetLength(0); ++row)
                {
                    if (flags[a[row, col] - 1] == 1)
                        return false;
                    flags[a[row, col] - 1] = 1;
                }
            }


            return true;
        }
    }
}
