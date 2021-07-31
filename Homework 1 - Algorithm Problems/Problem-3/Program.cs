using System;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            // Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.Write("Enter a positive 'n' number : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Type "+n+" Words\n------------");

            string[] words = new string[n];

            for(int i=0;i<n;i++){

                Console.Write((i+1)+". Word : ");
                words[i] = Console.ReadLine().Trim();

            }
            
            Console.Write("\nNormal   : ");
            foreach (var item in words)
            {

                Console.Write("["+item+"] ");

            }

            Array.Reverse(words);

            
            Console.Write("\n\nReversed : ");
            foreach (var item in words)
            {

                Console.Write("["+item+"] ");

            }


        }
    }
}
