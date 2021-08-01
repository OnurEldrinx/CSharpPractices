using System;
using System.Collections.Generic;

namespace Collections_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary

            //Syntax => Dictionary <key_data_type, value_data_type> dictionary_name = new Dictionary <key_data_type, value_data_type> ();

            Dictionary <int,string> galatasarayXI = new Dictionary<int, string>();

            galatasarayXI.Add(1,"Muslera");
            galatasarayXI.Add(45,"Marcao");
            galatasarayXI.Add(27,"Luyindama");
            galatasarayXI.Add(2,"Yedlin");
            galatasarayXI.Add(66,"Arda");
            galatasarayXI.Add(54,"Emre Kılınç");
            galatasarayXI.Add(7,"Kerem");
            galatasarayXI.Add(89,"Feghouli");
            galatasarayXI.Add(69,"Aanholt");
            galatasarayXI.Add(31,"Mostafa");
            galatasarayXI.Add(9,"Falcao");


            foreach (var item in galatasarayXI)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Goalkeeper : "+galatasarayXI[1]);

            //Count
            Console.WriteLine("There are "+galatasarayXI.Count+" footballers in the team right now.");

            //Contains

            if(galatasarayXI.ContainsValue("Falcao")){


                Console.WriteLine("Falcao is not in hospital.\nWhat a surprise!");


            }

            //Remove

            galatasarayXI.Remove(66,out string value);

            Console.WriteLine(value + " is out right now.");

            

        }
    }
}
