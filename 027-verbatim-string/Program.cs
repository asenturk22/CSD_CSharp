namespace _027_verbatim_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;

            s = "c:\temp\a.dat";
            System.Console.WriteLine(s);

            s = @"c:\temp\a.dat";
            System.Console.WriteLine(s);

            s = @"Bugün hava
çok güzel";
            System.Console.WriteLine(s);

        }
    }
}
