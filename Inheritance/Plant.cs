using System;

namespace Inheritance
{
    class Plant:LivingCreature
    {
        
        public void photosynthesize(){

            Console.WriteLine("Plants can photosynthesize.");

        }

    }

    class FloweringPlant:Plant
    {

        public void reproduceBySeed(){

            Console.WriteLine("Flowering plants reproduce with their seeds.");

        }

    }

    class CryptogamicPlant:Plant
    {

        public void reproduceBySporification(){

            Console.WriteLine("Cryptogamic plants reproduce by sporification.");

        }

    }
}