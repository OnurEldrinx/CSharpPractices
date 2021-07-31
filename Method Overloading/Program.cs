using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 'out' keyword : It works in the same way with 'ref' but there is a difference between them. 
            // When we use 'out', we don't need to initialize the variable.

            string number = "999";

            bool condition = int.TryParse(number,out int integerNumber);

            if(condition){

                Console.WriteLine("String is converted into integer successfully.");
                Console.WriteLine("Integer: " + integerNumber);


            }else{

                Console.WriteLine("It is not possible to convert this string into an integer value.");
                Console.WriteLine("String: " + number);
            }

            Methods.sum(8,15,out int result);
            Console.WriteLine("Result : "+result);

        }
    }


    class Methods
    {

        public static void sum(int a,int b,out int result){

            result = a+b;
            
        }

        // Method Overloading

        // Different types of parameters and different numbers of parameters.
        public static void sum(int a,int b,int c,int d,out int result){

            result = a+b+c+d;

        }



    }
}
