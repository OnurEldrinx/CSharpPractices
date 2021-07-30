using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //For Loop - Break - Continue

            Console.Write("Enter a number: ");
            int stop = int.Parse(Console.ReadLine());

            for(int i=1;i<=stop;i++){

                if(i % 2 != 0){

                    Console.Write("[" + i + "] ");

                }

            }

            Console.WriteLine();

            //Sum of odd numbers and even numbers from 0 to 1000

            int sumOfOddNumbers = 0;
            int sumOfEvenNumbers = 0;

            for(int i=0;i<=1000;i++){


                if(i % 2 == 0){

                    sumOfEvenNumbers += i;

                }else{

                    sumOfOddNumbers += i;

                }


            }

            Console.WriteLine("Sum of Odd Numbers  : "+sumOfOddNumbers);
            Console.WriteLine("Sum of Even Numbers : "+sumOfEvenNumbers);

            // break

            int key = 190155;
            for(int i=0;;i++){

                if(i == key){

                    Console.WriteLine("Password is cracked");
                    Console.WriteLine("Password : " + i);
                    break;

                }

            }

            // continue

            // This 'for loop' skips 5 and its multiples.

            for(int i=0;i<=100;i++){

                if(i % 5 == 0){

                    Console.WriteLine("Multiple of 5");
                    continue;

                }

                Console.WriteLine(i);
            }


        }
    }
}
