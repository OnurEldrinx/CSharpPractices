using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {

        

            try{
            
            Console.Write("Enter the first number: ");
            string number1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            string number2 = Console.ReadLine();

            int n1,n2;

            n1 = int.Parse(number1);
            n2 = int.Parse(number2);

            int sum = n1 + n2;

            Console.WriteLine(n1 + " + " + n2 + " = " + sum);

            }catch(Exception e){

                Console.WriteLine("There is an error.");
                Console.WriteLine("Exception Message: " + e.Message.ToString());

            }finally{

                Console.WriteLine("Process is completed.");

            }

            //An example for specific exception handling
            try{

                int number = int.Parse(null);

                Console.WriteLine("The number you entered is " + number); 

            }catch(ArgumentNullException e){

                Console.WriteLine("Error : "+e.Message.ToString());

            }


            

        }
    }
}
