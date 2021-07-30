using System;

namespace While_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //While

            int counter = 1;
            int sum = 0;

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());


            while(counter <= number){
                
                
                sum = sum + counter;

                counter++;
            
            }

            counter = number;

            Console.WriteLine("Average : "+sum+"/"+counter+" = "+(sum/counter));

            // Print 'A' to 'Z'

            char c = 'A';

            while(c <= 'Z'){

                Console.Write(c + " ");
                c++;

            }

            // For-Each

            string[] cars = {"BMW","AUDI","NISSAN","FERRARI","MERCEDES"};

            Console.WriteLine("\n\n---------- MY CARS ----------\n");
            foreach (var item in cars)
            {
                
                Console.WriteLine("--> "+ item);

            }

        }
    }
}
