using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();
            Bird bird = new Bird();

            // Polymorphism
            animal.talk();
            dog.talk();
            cat.talk();
            bird.talk();

            

        }
    }
}
