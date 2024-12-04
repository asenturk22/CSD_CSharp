namespace _038_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Executive e = new Executive();
            e.DispExecutive();
            e.DispManager();
            e.DispEmployee();

            Worker w = new Worker();
            w.DispWorker();
            w.DispEmployee();
        }
    }


    public class Employee
    {
        public void DispEmployee()
        {
            Console.WriteLine("Employee info");
        }
        //...
    }

    public class Worker : Employee
    {
        public void DispWorker()
        {
            Console.WriteLine("Worker info");
        }
        //...
    }
    public class Manager : Employee
    {
        public void DispManager()
        {
            Console.WriteLine("Manager info");
        }
        //...
    }

    public class Executive : Manager
    {
        public void DispExecutive()
        {
            Console.WriteLine("Executive info");
        }
    }
}
