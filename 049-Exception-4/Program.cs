namespace _049_Exception_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Test";
            string k = null;

            try
            {
                DispMessage(s);
                DispMessage(k);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void DispMessage(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
            Console.WriteLine(s);
        }
    }
}



/*
            Exception
                ^
                |
         SystemException
                ^
                |
         -----------------------------------------------------------------------------------------------------------------------------------------
         |                              |                       |                               |                           |
    ArgumentException           FormatException             IndexOutRangeException          InvalidCastException        NullRefererenceException
         |
----------------------------------
|                                 |
ArgumentNullException           ArgumentOutOfRangeException
 
 */
