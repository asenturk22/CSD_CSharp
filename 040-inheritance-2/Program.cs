namespace _040_inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
             Türemiş Sınıf Referansının Taban Sınıf Referansına Atanmasının Anlamı
Türemiş sınıf referansının taban sınıf referansına atanması sayesinde biz bir türetme şeması üzerinde genel
işlemler yapan metotlar yazabiliriz. 
            
             */

            Executive e = new Executive("Salih Tan", 30000, "Üretim", "Asya");
            Worker w = new Worker("Ali Serçe", 2000, Shift.Morning);
            DispTitle(e);
            DispTitle(w);


        }

        public static void DispTitle(Employee e)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(e.Name);
            Console.WriteLine(e.Salary);
            Console.WriteLine("--------------------------");
        }
    }
    
    enum Shift
    {
        Morning, Noon, Evening
    }

    class Employee
    {
        private string m_name;
        private int m_salary;

        public Employee()
        {

        }

        public Employee(string name, int salary)
        {
            m_name = name;
            m_salary = salary;
        }

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public int Salary
        {
            get { return m_salary; }
            set { m_salary = value; }
        }

    }

    class Worker : Employee
    {
        private Shift m_shift;

        public Worker()
        {

        }

        public Worker(string name, int salary, Shift shift) : base (name, salary)
        {
            m_shift = shift; 
        }

        public Shift Shift
        {
            get { return m_shift; }
            set { m_shift = value; }
        }
    }

    class Manager : Employee
    {
        private string m_department;

        public Manager()
        {

        }

        public Manager(string name, int salary, string depertament) : base (name, salary)
        {
            m_department = depertament;
        }

        public string Department
        {
            get { return m_department; }
            set { m_department = value; }
        }
    }

    class Executive : Manager
    {
        private string m_region;

        public Executive()
        {

        }

        public Executive(string name, int salary, string depertament, string region)
            : base (name, salary, depertament) 
        {
            m_region = region; 
        }

        public string Region
        {
            get { return m_region; }
            set { m_region = value; }
        }
    }
}
