using System;

namespace Access_Modifiers___Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Constructors
            Animal lion = new Animal("Lion","Felidae",5,"Forest");
            Animal cat = new Animal("Cat","Felidae",4,"Domestic");
            Animal spider = new Animal("Animal","Arachnida",1,"Forest");

            lion.printInfo();
            cat.printInfo();
            spider.printInfo();


        }
    }

}

class Animal{

    public string name;
    public string species;
    public int age;
    public string habitation;

    public Animal(string name, string species, int age, string habitation)
    {
        this.name = name;
        this.species = species;
        this.age = age;
        this.habitation = habitation;

    }

    // Default
    public Animal(){
    
    }

    // Overloaded
    public Animal(string name,string species){

        this.name = name;
        this.species = species;

    }

    public void printInfo(){

        Console.WriteLine("----------------------");
        Console.WriteLine("Name       :"+this.name);
        Console.WriteLine("Family     :"+this.species);
        Console.WriteLine("Age        :"+this.age);
        Console.WriteLine("Habitation :"+this.habitation);
        Console.WriteLine("----------------------");



    }

    
}

