using System;

namespace Recursive_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Extension Method Usage

            Console.Write("Enter a number to check out whether it's even or not: ");
            int number = int.Parse(Console.ReadLine());

            if(number.isEven()){

                Console.WriteLine(number + " is a even number!");

            }else{

                Console.WriteLine(number + " is a odd number!");

            }


            // Sorting an array with my extension method

            int[] myArray = {2,1,6,3,9,4,7,5,0};

            myArray.sort();

            Console.Write("\nSorted myArray: ");
            foreach (var item in myArray)
            {

                Console.Write(item + " ");
                
            }

            Console.WriteLine("\n");

            Console.Write("\nEnter a number to generate N-Element Fibonacci Series: ");
            int elementNumber = int.Parse(Console.ReadLine());
            Console.Write(elementNumber+"-Element Fibonacci Series : ");

            for(int i=0;i<elementNumber;i++){

                Console.Write(fibonacci(i) + " ");

            }
        }


        //Recursive Method : Fibonacci Series

        public static int fibonacci(int n){

            if(n==0){

                return 0;

            }

            if(n==1){

                return 1;

            }

            return fibonacci(n-1) + fibonacci(n-2);



        }
    }

    public static class MyExtensionMethods{

        public static bool isEven(this int number){

            if(number % 2 == 0){

                return true;

            }else{

                return false;

            }

        }

        public static int[] sort(this int[] array){

            Array.Sort(array);
            
            return array;

        }



    }

}
