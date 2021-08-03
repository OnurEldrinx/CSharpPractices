using System;
using static Abstract_Classes.Constants;

namespace Abstract_Classes
{

    public abstract class Car
    {

        public abstract int howManyWheels();
        public abstract Brand brand();
        public abstract Color defaultColor();



    }

    public class Mustang : Car
    {
        public override Brand brand()
        {
            return Brand.Ford;
        }

        public override Color defaultColor()
        {
            return Color.Black;
        }

        public override int howManyWheels()
        {
            return 4;
        }
    }

    public class Urus : Car
    {
        public override Brand brand()
        {
            return Brand.Lamborghini;
        }

        public override Color defaultColor()
        {
            return Color.White;
        }

        public override int howManyWheels()
        {
            return 4;
        }
    }

    public class Civic : Car
    {
        public override Brand brand()
        {
            return Brand.Honda;
        }

        public override Color defaultColor()
        {
            return Color.Gray;
        }

        public override int howManyWheels()
        {
            return 4;
        }
    }

}