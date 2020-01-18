using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class VolumeService : IVolumeService
    {
        public int Volume(ISolid solid)
        {
            return solid.Volume();
        }
    }
}
