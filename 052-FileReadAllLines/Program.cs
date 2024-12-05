namespace _052_FileReadAllLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                foreach (string line in File.ReadAllLines(@"..\..\..\Program.cs")) 
                    Console.WriteLine(line);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            string[] lines = { "Ali", "Veli", "Selami" };
            try
            {
                File.WriteAllLines("test.txt", lines);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}
