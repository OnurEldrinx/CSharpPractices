using System;

namespace Class_Definition
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee computerEngineer = new Employee();
            computerEngineer.name = "Onur";
            computerEngineer.surname = "Öztop";
            computerEngineer.id = 35;
            computerEngineer.department = "Cybersecurity Headquarter";

            Employee doctor = new Employee();
            doctor.name = "Sarah";
            doctor.surname = "Lee";
            doctor.id = 21;
            doctor.department = "Infirmary";

            computerEngineer.printInfo();
            doctor.printInfo();
        }
    }


    class Employee
    {
        
        public string name;
        public string surname;
        public int id;
        public string department;


        public void printInfo(){

            Console.WriteLine("------------------------------");
            Console.WriteLine("Full Name".PadRight(15)+": "+this.name+" "+this.surname);
            Console.WriteLine("ID".PadRight(15)+": "+this.id);
            Console.WriteLine("Department".PadRight(15)+": "+this.department);
            Console.WriteLine("------------------------------");

        }


    }

}
