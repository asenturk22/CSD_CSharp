namespace _011_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region goto : iç içe döngülerde tek hamlede çıkmak için, 
            for (int i = 0; i < 10; ++i)
            {
                for (int k = 0; k < 10; ++k)
                {
                    System.Console.WriteLine("({0}, {1})", i, k);
                    if (System.Console.ReadKey(true).KeyChar == 'q')
                        goto EXIT;
                }
            }
        EXIT:
            ;
            #endregion


        }
    }
}
