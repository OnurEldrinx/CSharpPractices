using System;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Please, type a sentence    : ");
            string sentence = Console.ReadLine().Trim();

            string[] words;

            words = sentence.Split(' ');



            int wordCounter = 0;
            int spaceCounter = 0;
            int charCounter = 0;

            foreach (var c in sentence)
            {
                


                if(c.Equals(' ')){

                    spaceCounter++;

                }


            }

            wordCounter = spaceCounter+1;
            charCounter = sentence.Length-spaceCounter;

            Console.WriteLine("Total Number of Words      : " + words.Length);
            Console.WriteLine("Total Number of Characters : " + charCounter);
            Console.WriteLine("Total Number of Spaces     : " + spaceCounter);

        }
    }
}
