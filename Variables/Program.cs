using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
    

            byte  a = 5;           // 1 byte
            Console.WriteLine(a);
            
            sbyte b = 5;           // 1 byte
            Console.WriteLine(b);
            
            short  c = 5;          // 2 byte
            Console.WriteLine(c);

            ushort d = 5;          // 2 byte
            Console.WriteLine(d);

            int   e = 2;           // 4 byte
            Console.WriteLine(e);

            uint  i = 2;           // 4 byte
            Console.WriteLine(i);

            Int16 f = 2;           // 2 byte
            Console.WriteLine(f);

            Int32 g = 2;           // 4 byte
            Console.WriteLine(g);

            Int64 h = 2;           // 8 byte
            Console.WriteLine(h);
            
            long  j = 4;           // 8 byte
            Console.WriteLine(j);

            ulong k = 4;           // 8 byte
            Console.WriteLine(k);

            //Real Numbers
            float   l = 3.5f;      // 4 byte
            Console.WriteLine(l);

            double  m = 7.5;       // 8 byte
            Console.WriteLine(m);

            decimal n = 1985.15m;  // 16 byte
            Console.WriteLine(n);
 
            char o = 'O';          // 2 byte
            Console.WriteLine(o);

            string name = "Onur";  // infinite     
            Console.WriteLine(name);

            bool b1 = true;
            Console.WriteLine(b1);

            bool b2 = false;
            Console.WriteLine(b2);
            
        
            DateTime today = DateTime.Now;         
            Console.WriteLine("Current Date & Time --> " + today);


            object x = "x";
            object y = "yes";
            object z = 1;
            object w = 3.5f;

            //Strings

            string string1 = string.Empty;

            string1 = "Onur";
            string string2 = "Oz";

            string fullName = string1 + " " + string2;

            Console.WriteLine(fullName);

            //Integers

            int int1=2;
            int int2=5;

            int int3 = int2 * int1;

            bool bool1 = 10 < 2; //false
            bool bool2 = 5 > 0;  //true
            bool bool3 = bool1 & bool2;

            Console.WriteLine(bool3);

            //Transformation between variable types

            string str1 = "20";
            int integer1 = 10;

            //ToString()
            Console.WriteLine(str1 + integer1.ToString()); //2010

            //Convert.To(string s) and int.Parse(string s)
            int newStr1 = Convert.ToInt32(str1);
            newStr1 = int.Parse(str1);

            Console.WriteLine(integer1+newStr1);

            string dateTime1 = DateTime.Now.ToString("dd/MM/yyyy");
            string dateTime2 = DateTime.Now.ToString("dd-MM-yyyy");


            Console.WriteLine(dateTime1);
            Console.WriteLine(dateTime2);

            string time = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine(time);

        }
    }
}
