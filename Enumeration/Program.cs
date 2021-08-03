using System;

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {

            // Enums start from 0 as default.
            Console.WriteLine(Days.Monday);//string
            Console.WriteLine((int)Days.Monday);//int
            Console.WriteLine((int)Days.Friday);

            int temperature = -5;

            if(temperature <= (int)AirTemperature.Cold){

                Console.WriteLine("Cold");

            }else if(temperature <= (int)AirTemperature.Normal){

                Console.WriteLine("Normal");

            }else if(temperature < (int)AirTemperature.Hot){

                Console.WriteLine("Optimum");

            }else{

                Console.WriteLine("Hot");

            }

            

            
        }
    }
}

enum Days{

    Monday = 1, // indexes start from 1 in this way.
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday


};

enum AirTemperature
{
    
    Cold = 5,
    Normal = 20,
    Hot = 30,

}

 class Operations{

    private static int a;
    private static int b;

    static Operations()
    {
       
    }

    public Operations()
    {
    }
}