using System;

namespace Interface_Example
{

    public class Urus : ICar
    {
        public Brand brand()
        {
            return Brand.Lamborghini;
        }

        public Color defaultColor()
        {
            return Color.White;
        }

        public int howManyWheels()
        {
            return 4;
        }
    }

}