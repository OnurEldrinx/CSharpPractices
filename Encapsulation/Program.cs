using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student student1 = new Student("Onur","Öztop",200602036,2);

            student1.printInfo();

            student1.gradeUp();

            student1.printInfo();

            student1.gradeDown();
            student1.gradeDown();
            student1.gradeDown();

            student1.printInfo();

        }
    }
}

class Student{

    private string name;
    private string surname;
    private int id;
    private int grade;


    public void gradeUp(){

        this.Grade++;

    }

    public void gradeDown(){

        this.Grade--;

    }

    public void printInfo(){

        Console.WriteLine("------------------------");
        Console.WriteLine("Full Name : "+this.Name+" "+this.Surname);
        Console.WriteLine("ID        : "+this.Id);
        Console.WriteLine("Grade     : "+this.Grade);
        Console.WriteLine("------------------------");

    }

    public Student()
    {

    }

    public Student(string name, string surname, int id, int grade)
    {
        this.Name = name;
        this.Surname = surname;
        this.Id = id;
        this.Grade = grade;
    }

    public string Name { 
        
        get{
            
            return name;
        
        } 
        
        set{

            name = value;

        }  
        
    }

    public string Surname { get => surname; set => surname = value; }
    public int Id { get => id; set => id = value; }
    public int Grade { 
        
        get => grade; 
    
        set 
        {
            
            if(value < 1){

                Console.WriteLine("Grade must be 1 at least.");
                grade = 1;

            }else{

                grade = value;

            }
                
        } 
        
        
    }
}