using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {


            // If-Else

            int time = DateTime.Now.Hour;

            if(time < 12){

                Console.WriteLine("Good Morning!");
            
            }else if(time < 18){

                Console.WriteLine("Have a nice day!");

            }else if(time < 23){

                Console.WriteLine("Good Evening!");

            }else{

                Console.WriteLine("Good Night!");

            }


            string messageText = time <= 18 ? "Have a nice day!" : "Good evening!";
            Console.WriteLine(messageText); 

        }
    }
}
