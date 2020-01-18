using System;

namespace Project1
{
    public class Circle : IShape
    {
        private const decimal pi = 3.14M;

        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        int IShape.Area()
        {
            return Convert.ToInt32(pi * Radius * Radius);
        }
    }
}
