using System;
using System.Collections.Generic;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
                ve dizinin elemanlarını sıralayan programı yazınız.
            */
            
            // Sesli Harfler: a, e, ı, i, o, ö, u, ü

            string sentence;

            List<char> sesliHarfler = new List<char>();

            char[] SESLİ_HARFLER = {'a','e','ı','i','o','ö','u','ü'};

            Console.Write("\nLütfen bir cümle yazınız : ");
            sentence = Console.ReadLine().ToLower();

            for(int i=0;i<sentence.Length;i++){

                for(int j=0;j<SESLİ_HARFLER.Length;j++){


                        if(sentence[i] == SESLİ_HARFLER[j]){

                            sesliHarfler.Add(SESLİ_HARFLER[j]);

                        }


                }
                
            }

            sesliHarfler.Sort();

            int a=0,e=0,ı=0,ii=0,o=0,ö=0,u=0,ü=0;
            

            Console.WriteLine("\nBu cümlede bulunan sesli harfler ve sayıları aşağıda sıralanmıştır!");
            Console.WriteLine("-------------------------------------------------------------------");
            foreach (var item in sesliHarfler)
            {
                
                Console.Write("["+item+"] ");

                switch(item){

                    case 'a':
                        a++;
                        break;
                    case 'e':
                        e++;
                        break;    
                    case 'ı':
                        ı++;
                        break;
                    case 'i':
                        ii++;
                        break;
                    case 'o':
                        o++;
                        break;
                    case 'ö':
                        ö++;
                        break;
                    case 'u':
                        u++;
                        break;
                    case 'ü':
                        ü++;
                        break;

                }


            }
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.WriteLine("------------");
            Console.WriteLine("a --> "+a+" Adet");
            Console.WriteLine("e --> "+e+" Adet");
            Console.WriteLine("ı --> "+ı+" Adet");
            Console.WriteLine("i --> "+ii+" Adet");
            Console.WriteLine("o --> "+o+" Adet");
            Console.WriteLine("ö --> "+ö+" Adet");
            Console.WriteLine("u --> "+u+" Adet");
            Console.WriteLine("ü --> "+ü+" Adet");
            Console.WriteLine("------------");

        }
    }
}
