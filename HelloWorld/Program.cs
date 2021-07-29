using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Your name:");
            string name = Console.ReadLine();
            Console.Write("Your Surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Hello World!\nThis is "+name+" "+surname);
        
        }
    }
}
