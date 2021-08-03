using System;

namespace Interface_Example
{

    public class Corolla : ICar
    {
        public Brand brand()
        {
            return Brand.Toyota;
        }

        public Color defaultColor()
        {
            return Color.Gray;
        }

        public int howManyWheels()
        {
            return 4;
        }
    }

}