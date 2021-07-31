using System;

namespace ArrayClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sort

            int[] array1 = {3,15,87,25,14,5,35,1,0};
            
            Console.Write("Unsorted Array1 : ");
            foreach (var item in array1)
            {
                
                Console.Write(item + " ");

            }

            Array.Sort(array1);

            Console.Write("\nSorted Array1 : ");
            foreach (var item in array1)
            {
                
                Console.Write(item + " ");

            }

            //Clear

            Console.WriteLine("\n");
            Array.Clear(array1,0,3); // Assign zero to 3 elements of this array by starting from the zeroth index.
            foreach (var item in array1)
            {
                
                Console.Write(item + " ");

            }


            //Reverse

            Array.Reverse(array1);
            Console.Write("\nReversed Array1 : ");
            foreach (var item in array1)
            {
                
                Console.Write(item + " ");

            }

            //IndexOf

            Console.WriteLine("\n");
            Console.WriteLine("Index of 35 : "+Array.IndexOf(array1,35));

            //Resize

            Array.Resize<int>(ref array1,15);
            Console.Write("\nResized Array1 : ");
            foreach (var item in array1)
            {
                
                Console.Write(item + " ");

            }


        }
    }
}
