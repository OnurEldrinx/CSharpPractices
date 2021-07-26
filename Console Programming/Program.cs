using System;

namespace Console_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Your Name : ");
            string name = Console.ReadLine();

            Console.Write("Your Surname : ");
            string surname = Console.ReadLine();

            Console.WriteLine("Welcome "+name+" "+surname);
        }
    }
}
