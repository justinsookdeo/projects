using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public interface ISolid
    {
        IShape Shape { get; set; }
        int Height { get; set; }
        public int Volume();
    }
}
