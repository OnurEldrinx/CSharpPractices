using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Initialize an Array

            string[] colors = new string[5];

            string[] animals = {"Cat","Dog","Bird","Cheetah","Lion"};

            int[] numbers;

            numbers = new int[10]; 

            colors[0] = "Red";

            numbers[9] = 9;

            Console.WriteLine(colors[0] +" - "+animals[3]+" - "+numbers[9]);


            // Loops and Arrays

            Console.Write("Length of the Array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            int sum = 0;

            for(int i=0;i<array.Length;i++){

                Console.Write("Enter " + (i+1) + "." + "Number: ");
                array[i] = int.Parse(Console.ReadLine());

                sum = sum + array[i];

            }

            Console.WriteLine("Average: "+(sum/array.Length));

        }
    }
}
