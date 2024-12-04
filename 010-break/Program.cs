namespace _010_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;

            for (; ; )
            {
                System.Console.Write("CSD:> ");
                ch = System.Console.ReadKey(true).KeyChar;
                System.Console.WriteLine(ch);

                if (ch == 'q')
                    break;
                if (ch == 'd')
                    System.Console.WriteLine("dir command");
                else if (ch == 'r')
                    System.Console.WriteLine("remove command");
                else if (ch == 'c')
                    System.Console.Clear();
                else System.Console.WriteLine("{0}: command not found!", ch );
            }
        }
    }
}
