using System;

namespace Abstract_Classes
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

            Civic civic = new Civic();
            Console.WriteLine("\n-------- Civic --------");
            Console.WriteLine("Brand".PadRight(10)+ ": " + civic.brand().ToString());   
            Console.WriteLine("Wheels".PadRight(10)+ ": " + civic.howManyWheels().ToString());
            Console.WriteLine("Color".PadRight(10)+ ": " + civic.defaultColor().ToString());

        }
    }
}
