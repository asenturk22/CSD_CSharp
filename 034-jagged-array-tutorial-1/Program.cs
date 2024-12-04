namespace _034_jagged_array_tutorial_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] students;

            students = new string[4][];

            students[0] = new string[5] { "Ali", "Veli", "Selami", "Ayşe", "Fatma"};
            students[1] = new string[3] { "Ali", "Veli", "Selami" };
            students[2] = new string[4] { "Erhan", "Ayhan", "Sibel", "Şükrü" };
            students[3] = new string[2] { "İnci", "İsmet" };

            for (int i = 0; i < students.Length; ++i)
            {
                for (int k = 0; k < students[i].Length; ++k)
                {
                    if (k != 0)
                        Console.Write(", ");

                    Console.Write("{0}", students[i][k]);    
                }
                Console.WriteLine();
            }
        }
    }
}
