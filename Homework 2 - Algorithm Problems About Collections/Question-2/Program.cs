using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            // Her iki grubun kendi içerisinde ortalamalarını alan, 
            // Bu ortalamaları ve ortalama toplamlarını konsola yazdıran programı yazınız.
            // Array sınıfını kullanarak yazınız.

            int[] maxTriplet = new int[3];
            int[] minTriplet = new int[3];

            double maxAverage = 0;
            double minAverage = 0;

            double maxSum = 0;
            double minSum = 0;

            int[] numbers = new int[20]; // It is mentioned that we need 20 numbers.

            for(int i=0;i<20;i++){

                try{

                    Console.Write("Enter a number : ");
                    numbers[i] = int.Parse(Console.ReadLine());

                }catch(Exception e){

                    Console.WriteLine(e.Message.ToString());
                    continue; // Default value(0) is taken for current numbers[i] object.
                    
                }

            }

            Array.Sort(numbers); // Numbers sorted. 

            // Max 3 numbers' indexes must be [numbers.length-1],[numbers.length-2],[numbers.length-3] logically.
            // Min 3 numbers' indexes must be [0] [1] [2] logically.

            maxTriplet[0] = numbers[numbers.Length-3];
            maxTriplet[1] = numbers[numbers.Length-2];
            maxTriplet[2] = numbers[numbers.Length-1];

            minTriplet[0] = numbers[0];
            minTriplet[1] = numbers[1];
            minTriplet[2] = numbers[2];

            
            foreach (var item in maxTriplet)
            {
                
                maxSum += item;

            }
            maxAverage = maxSum / (maxTriplet.Length);

            foreach (var item in minTriplet)
            {
                
                minSum += item;

            }
            minAverage = minSum / (minTriplet.Length);

            //Results

            Console.Write("\nNumbers".PadRight(15)+": ");
            foreach (var item in numbers)
            {
                Console.Write("["+item+"] ");
            }
            Console.WriteLine();
            Console.Write("\nMax Triplet".PadRight(15)+": ");
            foreach (var item in maxTriplet)
            {
                
                Console.Write("["+item+"] ");

            }
            Console.WriteLine();
            Console.Write("\nMin Triplet".PadRight(15)+": ");
            foreach (var item in minTriplet)
            {
                
                Console.Write("["+item+"] ");

            }
            Console.WriteLine();
            Console.WriteLine("\nSum of Max Triplet     : "+maxSum);
            Console.WriteLine("Average of Max Triplet : "+maxAverage);
            Console.WriteLine("\nSum of Min Triplet     : "+minSum);
            Console.WriteLine("Average of Min Triplet : "+minAverage);
            Console.WriteLine("\nSum of Averages        : "+(maxAverage+minAverage));

        }
    }
}
