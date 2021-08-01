using System;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string var1 = "Welcome to CSharp!";
            string var2 = "CSharp";

            //Length
            Console.WriteLine("Number of Characters: "+var1.Length);

            //ToUpper - ToLower
            Console.WriteLine(var2.ToUpper());
            Console.WriteLine(var2.ToLower());

            //Concat
            Console.WriteLine(String.Concat(var2," 101"));

            //Compare - CompareTo
            Console.WriteLine(var1.CompareTo(var2)); // -1 0 1
            Console.WriteLine(string.Compare(var1,var2,true));  // true  : ignore the case
            Console.WriteLine(string.Compare(var1,var2,false)); // false : don't ignore the case

            // Contains
            Console.WriteLine(var1.Contains(var2));
            Console.WriteLine(var1.StartsWith('W'));
            Console.WriteLine(var2.EndsWith('p'));

            // IndexOf
            Console.WriteLine(var1.IndexOf('C'));

            // LastIndexOf
            Console.WriteLine(var1.LastIndexOf('o'));

            //Insert
            Console.WriteLine(var1.Insert(0,"Hello! "));

            // PadLeft - PadRight
            Console.WriteLine("Galatasaray ".PadRight(15,'>') + " Real Madrid");

            // Remove
            Console.WriteLine(var2.Remove(1));

            // Replace
            Console.WriteLine(var1.Replace("CSharp","C#"));

            // Split
            Console.WriteLine(var1.Split(' ')[0]);

            // Substring
            Console.WriteLine(var1.Substring(5,8));
        }
    }
}
