namespace _052_FileReadAllBytes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                byte[] buf;

                buf = File.ReadAllBytes("052-FileReadAllBytes.exe");
                Console.WriteLine(BitConverter.ToString(buf));

                File.WriteAllBytes("new_052-FileReadAllBytes.exe", buf);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
