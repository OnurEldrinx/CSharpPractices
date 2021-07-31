using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {


            int a=5;
            int b=15;

            Methods.print(a+" + "+b+" = "+Methods.sum(a,b));

            // 'ref' keyword refers to the original address.
            // In this way, the current method works on the original object instead of a copy of it.

        }

        
    }

    class Methods
    {

        public static void print(object o){

            Console.WriteLine(o.ToString());

        }

        public static int sum(int a,int b){

            return a+b;

        } 




    }


}
