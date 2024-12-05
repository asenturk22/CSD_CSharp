namespace _053_FileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo("053-FileInfo.exe");
            Console.WriteLine(fi.Exists ? "Dosya Var" : "Dosya Yok");
            Console.WriteLine(fi.Length);

        }
    }
}
