using System;
using System.Collections;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
            // ArrayList sınıfını kullanarak yazınız.
            // Negatif ve numeric olmayan girişleri engelleyin.
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.


            ArrayList primeNumbers = new ArrayList();
            ArrayList notPrimeNumbers = new ArrayList();

            string input;
            bool flag=true;
            int dividerCounter = 0; // Each number can be divided by itself & 1.
            
            

            while(flag){

                if(primeNumbers.Count+notPrimeNumbers.Count == 20){

                    flag = false;

                }else{

                    try{
                        
                        Console.Write("Enter a number : ");
                        input = Console.ReadLine();

                        bool b = int.TryParse(input,out int number);

                        if(b){

                            
                            if(number < 0){

                                throw new Exception("Number you entered can't be negative.");
                            
                            }

                                

                                for(int i=1;i<=number;i++){

                                        if(number % i == 0){

                                            dividerCounter++;

                                        }

                                }

                                //Console.WriteLine("Divider Counter:"+dividerCounter);

                                if(dividerCounter > 2 || dividerCounter == 1){

                                        notPrimeNumbers.Add(number);
                                        

                                }else if(dividerCounter == 2){

                                        primeNumbers.Add(number);
                                        
                                }

                                dividerCounter = 0; //reset counter


                        }else{


                                throw new Exception("Invalid string input!");


                        }
                

                    }catch(Exception e){

                        
                        Console.WriteLine(e.Message.ToString());

                    
                    }

                }

            }


            //Results
            primeNumbers.Sort();
            notPrimeNumbers.Sort();

            double averagePrimes;
            double averageNotPrimes;

            int sumPrimes = 0;
            int sumNotPrimes = 0;

            foreach (var item in primeNumbers)
            {
                
                sumPrimes = sumPrimes + int.Parse(item.ToString());

            }
            averagePrimes = (double)sumPrimes / primeNumbers.Count;

            foreach (var item in notPrimeNumbers)
            {
                
                sumNotPrimes = sumNotPrimes + int.Parse(item.ToString());

            }
            averageNotPrimes = (double)sumNotPrimes / notPrimeNumbers.Count;


            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.Write("Prime Numbers".PadRight(30)+": ");
            foreach (var prime in primeNumbers)
            {
                Console.Write(prime+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum of Prime Numbers".PadRight(30)+": "+sumPrimes);
            Console.WriteLine("Prime Numbers Size".PadRight(30)+": "+primeNumbers.Count);
            Console.WriteLine("Average".PadRight(30)+": "+averagePrimes);
            Console.WriteLine("----------------------------------------------------------------------------------");

            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.Write("Normal Numbers".PadRight(30)+": ");
            foreach (var notPrime in notPrimeNumbers)
            {
                Console.Write(notPrime+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum of Not Prime Numbers".PadRight(30)+": "+sumNotPrimes);
            Console.WriteLine("Not Prime Numbers Size".PadRight(30)+": "+notPrimeNumbers.Count);
            Console.WriteLine("Average".PadRight(30)+": "+averageNotPrimes);
            Console.WriteLine("----------------------------------------------------------------------------------");


      
        }
           
    }
    
}
