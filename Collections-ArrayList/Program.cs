using System;
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList 
            // System.Collections -> namespace

            ArrayList a = new ArrayList();

            a.Add("Onur");
            a.Add(35);
            a.Add(true);
            a.Add('P');

            // Access to the elements

            Console.WriteLine(a[1]);

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n------------------------------------------------------------------------------------");

            // Add Range

            string[] colors = {"Red","Blue","Black","Yellow","Green"};

            a.AddRange(colors);

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine("\n------------------------------------------------------------------------------------\n");

            ArrayList b = new ArrayList();

            b.Add(5);
            b.Add(35);
            b.Add(1);

            foreach (var item in b)
            {
                Console.Write(item + " ");
            }

            // Sort
            b.Sort();

            // Binary Search
            Console.WriteLine("\n"+b.BinarySearch(35));

            // Reverse
            b.Reverse();
        
            foreach (var item in b)
            {
                Console.Write(item + " ");
            }

            //Clear

            b.Clear();

            Console.Write("\n[");
            foreach (var item in b)
            {
                Console.Write(item + " ");
            }
            Console.Write("]");
        }
    }
}
