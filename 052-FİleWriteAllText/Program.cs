namespace _052_FİleWriteAllText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = "Ali veli selami";

                File.WriteAllText("x.txt", s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
