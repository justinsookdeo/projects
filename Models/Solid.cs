using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class Solid : ISolid
    {
        public IShape Shape {get; set;}
        public int Height { get; set; }

        public Solid(IShape shape, int height)
        {
            Shape = shape;
            Height = height;
        }
        
        public int Volume()
        {
            return Shape.Area() * Height;
        }
    }
}
