using System;
using System.Collections.Generic;

namespace Static_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee e = new Employee();

            List<Employee> employees = new List<Employee>();

            Employee CEO = new Employee("Onur","Öztop",23);
            employees.Add(CEO);
            e.printAll(employees);
            Console.WriteLine("Employee Counter : "+Employee.EmployeeCounter);

            Employee computerEngineer = new Employee("Sara","Wayne",31);
            employees.Add(computerEngineer);
            e.printAll(employees);
            Console.WriteLine("Employee Counter : "+Employee.EmployeeCounter);

            Employee doctor = new Employee("Rose","Winters",26);
            employees.Add(doctor);
            e.printAll(employees);
            Console.WriteLine("Employee Counter : "+Employee.EmployeeCounter);

            Console.WriteLine("\nCEO.Age + doctor.Age = "+Operations.sum(doctor.Age,CEO.Age));
            Console.WriteLine("CEO.Age x doctor.Age = "+Operations.multiply(doctor.Age,CEO.Age));
        }
    }
}

class Employee{

    private static int employeeCounter;
    private string name;
    private string surname;
    private int age;

    public void printAll(List<Employee> employees){

        foreach (var employee in employees)
        {
            
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Full Name : "+employee.name+" "+employee.surname);
            Console.WriteLine("Age       : "+employee.age);
            Console.WriteLine("-----------------------------");

        }

    }

    public Employee()
    {

    }

    public Employee(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;

        employeeCounter++;
    }

    public static int EmployeeCounter { get => employeeCounter;}
    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public int Age { get => age; set => age = value; }
}

static class Operations{


    public static int sum(int a,int b){

        return (a+b);

    }

    public static int multiply(int a,int b){

        return (a*b);

    }

}