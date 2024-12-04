namespace _014_sinif_calismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             System.Console.WindowWidth  : ekranın genişliğini
             System.Console.WindowHeight : ekranın yüksekliğini veren özellik

             * karakteri pencerenin bir kenarına geldiğinde diğer karşı kenardan çıksın. 
             */

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

                switch (ch)
                {
                    case 'a':
                        if (col == 0)
                            col = System.Console.WindowWidth - 1;
                        else
                            --col;
                        break;
                    case 'w':
                        if (row == 0)
                            row = System.Console.WindowHeight - 1;
                        else
                            --row;
                        break;
                    case 's':
                        if (row == System.Console.WindowHeight - 1)
                            row = 0;
                        else
                            ++row;
                        break;
                    case 'd':
                        if (col == System.Console.WindowWidth - 1)
                            col = 0;
                        else
                            ++col;
                        break;
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


//Farklı Türlerin Birbirlerine Atanması ve Otomatik Tür Dönüştürmeleri burda kaldım. 