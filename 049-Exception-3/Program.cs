namespace _049_Exception_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path;
            string[] files;

            Console.Write("Lütfen bir yol ifadesi giriniz:");
            path = Console.ReadLine();

            try
            {
                files = Directory.GetFiles(path);
                foreach (string file in files)
                    Console.WriteLine(Path.GetFileName(file));
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("İlgili dizin bulunamadı!..");
            }
        }
    }
}
