using System;

namespace Polymorphism
{
    class Animal
    {
        
        public virtual void talk(){

            Console.WriteLine("Animal talks.");

        } 
        

    }

    class Cat:Animal
    {

        public override void talk(){

            Console.WriteLine("Cat meows.");

        }

    }

    class Dog:Animal
    {

        public override void talk(){

            Console.WriteLine("Dog barks.");

        }

    }

    class Bird:Animal
    {

        public override void talk(){

            Console.WriteLine("Bird sings.");

        }

    }

}