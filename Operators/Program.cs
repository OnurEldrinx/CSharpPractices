using System;

namespace Operators
{
    class Program
    {

        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {

        double tip = (meal_cost * tip_percent)/100;
        double tax = (meal_cost * tax_percent)/100;
        double result = meal_cost + tax + tip;

        Console.WriteLine(Math.Round(result));
        
        }


        static void Main(string[] args)
        {

            // Assignment
            // =  +=  -=  *=  /= 

            int x = 2;
            int y = 3;

            y = y+2; //y += 2
            x = x/2; //x /= 2

            x *= 3;

            Console.WriteLine("x:"+x);
            Console.WriteLine("y:"+y);

            // Logical Operators
            // Or  --> ||
            // And --> &&
            // Not --> !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isCompleted && isSuccess){

                Console.WriteLine("Perfect");

            }

            if(isCompleted || isSuccess){

                Console.WriteLine("Great");

            }

            if(!isCompleted && isSuccess){

                Console.WriteLine("Not Good");

            }

            // Relational Operators
            // > , < , >= , <= , == , !=

            int a = 3;
            int b = 4;

            if (a<b){

                Console.WriteLine("a is smaller than b");

            }else if(b<a){

                Console.WriteLine("b is smaller than a");


            }

            if(a != b){

                Console.WriteLine("a does not equal b");


            }


            // Arithmetic Operators
            // + - * / %

            int n1 = 15;
            int n2 = 3;

            int sum = n1 + n2 ;
            int division = n1 / n2;
            int multiplication = n1 * n2;
            int subtraction = n1 - n2;
            int mod = n1%n2; //remainder of n1/n2

            Console.WriteLine("sum             : "+sum);
            Console.WriteLine("division        : "+division);
            Console.WriteLine("multiplication  : "+multiplication);
            Console.WriteLine("subtraction     : "+subtraction);
            Console.WriteLine("mod             : "+mod);


            //Hackerrank Solution
            Program.solve(12,20,8);





        }
    }


    

}
