using System;

namespace Inheritance
{
    class Animal:LivingCreature
    {
        
        public void activeMovement(){

            Console.WriteLine("Animals can move actively.");

        }
        
    }

    class Bird:Animal
    {
        
        public void fly(){

            Console.WriteLine("Birds can fly.");

        }

    }

    class Duck:Animal
    {
        
        public void swim(){

            Console.WriteLine("Ducks can swim.");

        }

    }
}