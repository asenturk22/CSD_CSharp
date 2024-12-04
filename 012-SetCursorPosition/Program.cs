namespace _012_SetCursorPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {               
            char ch;
            int col = 20, row = 5;

            System.Console.CursorVisible = false;
            System.Console.SetCursorPosition(col, row);
            System.Console.Write("*");

            for (; ; )
            {
                ch = System.Console.ReadKey(true).KeyChar;

                if (ch == 'q')
                    break;

                System.Console.SetCursorPosition(col, row);
                System.Console.Write(" ");
                ++col;
                System.Console.SetCursorPosition(col, row); 
                System.Console.Write("*");
            }
        }
    }
}
