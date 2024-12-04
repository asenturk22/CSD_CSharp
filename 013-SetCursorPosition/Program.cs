namespace _013_SetCursorPosition
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

                System.Console.SetCursorPosition(col, row);
                System.Console.Write(" ");

                switch(ch)
                {
                    case 'a': --col; break;
                    case 'd': ++col; break;
                    case 'w': --row; break;
                    case 's': ++row; break;
                    case 'q':
                        goto EXIT; 
                }

                System.Console.SetCursorPosition(col, row);
                System.Console.Write("*");
            }

        EXIT:
            System.Console.CursorVisible = true; 
        }
    }
}
