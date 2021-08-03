using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();

            bird.eat();         // LivingCreature method
            bird.aspirate();    // LivingCreature method
            bird.excrete();     // LivingCreature method
            
            bird.activeMovement(); // Animal method

            bird.fly(); // Bird method

            CryptogamicPlant cryptogamicPlant = new CryptogamicPlant();

            cryptogamicPlant.eat();       // LivingCreature method
            cryptogamicPlant.aspirate();  // LivingCreature method
            cryptogamicPlant.excrete();   // LivingCreature method

            cryptogamicPlant.photosynthesize(); // Plant method

            cryptogamicPlant.reproduceBySporification(); // CryptogamicPlant method
        }
    }
}
