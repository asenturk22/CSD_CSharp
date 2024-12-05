namespace _052_FileExists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path;

            Console.Write("Bir yol ifadesi giriniz: ");
            path = Console.ReadLine();

            Console.WriteLine(File.Exists(path) ? "Dosya var." : "Dosya yok." );

            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(File.Exists(@"notepad.exe") ? "Var" : "Yok"); // Yok

            Environment.CurrentDirectory = @"c:\windows";
            Console.WriteLine(File.Exists(@"notepad.exe") ? "Var" : "Yok"); // Yok


        }
    }
}
