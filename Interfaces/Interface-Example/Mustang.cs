using System;

namespace Interface_Example
{

    public class Mustang : ICar
    {
        public Brand brand()
        {
            return Brand.Ford;
        }

        public Color defaultColor()
        {
            return Color.Black;
        }

        public int howManyWheels()
        {
            return 4; 
        }
    }

}