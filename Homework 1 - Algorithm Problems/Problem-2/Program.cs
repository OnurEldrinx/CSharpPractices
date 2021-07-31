using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.Write("\nEnter a positive 'n' value : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nEnter a positive 'm' value : ");
            int m = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("\nEnter " + n + " positive numbers!");
            for(int i=0;i<n;i++){

                Console.Write("Number-" + (i+1) + " : ");
                numbers[i] = int.Parse(Console.ReadLine());
                 
            }

            Console.WriteLine("\nOUTPUT OF PROBLEM-2\n-------------------");
            foreach (var item in numbers)
            {
                
                if(item % m == 0){


                    Console.WriteLine("--> "+item);
    

                }

            }


        }
    }
}
