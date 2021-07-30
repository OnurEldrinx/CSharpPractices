using System;

namespace Type_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Implicit Conversion (Bilinçsiz)
            // byte -> short -> int -> long -> float -> double -> decimal -> object

            Console.WriteLine("---------- Implicit Conversions ----------");

            byte a = 15;
            short c = 0;
            Console.WriteLine("a:"+a);
            Console.WriteLine("c:"+c);

            c = a;
            Console.WriteLine("c:"+c);

            int d = 179;
            Console.WriteLine("d:"+d);

            d = c;

            Console.WriteLine("d:"+d);
            


            //Explicit Conversion (Bilinçli)

            Console.WriteLine("---------- Explicit Conversions ----------");

            int x = 21;

            byte z = (byte)x;

            float w = 10.28f;

            int k = (int)w;

            //ToString

            int age = 21;

            string ageString = age.ToString();

            //System.Convert

            string number1 = "20",number2 = "10";

            int n1,n2,sum;

            n1 = Convert.ToInt32(number1);
            n2 = Convert.ToInt32(number2);

            sum = n1+n2;

            Console.WriteLine(number1+" + "+number2 + " = "+ (n1+n2));

            //Parse

            int n3 = Int32.Parse(number1); // "20" --> 20
            

        }
    }
}
