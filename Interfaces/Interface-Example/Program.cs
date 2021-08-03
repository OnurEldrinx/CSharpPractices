using System;

namespace Interface_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Mustang mustang = new Mustang();
            Console.WriteLine("------- MUSTANG -------");
            Console.WriteLine("Brand".PadRight(10)+ ": " + mustang.brand().ToString());   
            Console.WriteLine("Wheels".PadRight(10)+ ": " + mustang.howManyWheels().ToString());
            Console.WriteLine("Color".PadRight(10)+ ": " + mustang.defaultColor().ToString());
        
            Urus urus = new Urus();
            Console.WriteLine("\n------- U R U S -------");
            Console.WriteLine("Brand".PadRight(10)+ ": " + urus.brand().ToString());   
            Console.WriteLine("Wheels".PadRight(10)+ ": " + urus.howManyWheels().ToString());
            Console.WriteLine("Color".PadRight(10)+ ": " + urus.defaultColor().ToString());

            Corolla corolla = new Corolla();
            Console.WriteLine("\n------- COROLLA -------");
            Console.WriteLine("Brand".PadRight(10)+ ": " + corolla.brand().ToString());   
            Console.WriteLine("Wheels".PadRight(10)+ ": " + corolla.howManyWheels().ToString());
            Console.WriteLine("Color".PadRight(10)+ ": " + corolla.defaultColor().ToString());
        }
    }
}
