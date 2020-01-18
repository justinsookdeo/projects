using System;

namespace Project1
{
    public class Rectangle : IShape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public Rectangle(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public int Area()
        {
            return Length * Breadth;
        }
    }
}
