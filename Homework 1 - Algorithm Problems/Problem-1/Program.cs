using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            // Kullanıcının girmiş olduğu sayılardan çift olanları console'a yazdırın.

            while(true){ 

            Console.Write("Enter a positive number:");
            string number = Console.ReadLine();
            bool isOk = int.TryParse(number,out int n);

            if(isOk && n>0){

                int[] inputs = new int[n];

                for(int i=0;i<n;i++){

                    Console.Write((i+1)+".Number\t: ");
                    
                    try{

                        inputs[i] = int.Parse(Console.ReadLine());
                    
                    }catch(Exception e){
                        
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine(e.Message.ToString());
                        Console.WriteLine("This input isn't gonna processed!");
                        Console.WriteLine("--------------------------------------------");

                        inputs[i] = -1; //This input isn't gonna used!

                    }
                    
                }

                Console.Write("\nEVEN NUMBERS\n-----------\n");
                foreach (var item in inputs)
                {
                    
                    if(item % 2 == 0){

                        Console.WriteLine("--> "+ item);

                    }

                }

                break;

            }else{


                Console.WriteLine("!!! Your input was not a positive integer !!!");
                
            }

        }



        }
    }
}
