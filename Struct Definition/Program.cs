using System;

namespace Struct_Definition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class

            Rectangle rectangle = new Rectangle();
            rectangle.shortSide = 15;
            rectangle.longSide = 10;

            Console.WriteLine("Rectangle (Class) Area : "+rectangle.calculateArea());


            // Struct

            RectangleStruct rectangleStruct;
            rectangleStruct.shortSide = 20;
            rectangleStruct.longSide = 30;

            Console.WriteLine("Rectangle (Struct) Area : "+rectangleStruct.calculateArea());


        }
    }

}

class Rectangle{

    public int shortSide;
    public int longSide;

    public long calculateArea(){

        return (this.shortSide*this.longSide);

    }


}

struct RectangleStruct
{
    public int shortSide;
    public int longSide;

    // For structs, we can't define a constructor without parameters.
    public RectangleStruct(int shortSide, int longSide)
    {
        this.shortSide = shortSide;
        this.longSide = longSide;
    }

    
    // We must initialize all fields of the struct.

    // It can be better to use structs for data up to 16 bytes.


    public long calculateArea(){

        return (this.shortSide*this.longSide);

    }


}
