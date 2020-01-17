using System;

namespace Project1
{
    class Program
    {
        static readonly IVolumeService _volumeService;
        static ISolid _solid;

        static Program()
        {
            /// Inject the VolumeService using the Dependency Inversion Principle
            _volumeService = new VolumeService();
        }

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine($"{Environment.NewLine}Please enter a watertank solid shape : cube, cuboid or cylinder");
                string tank = Console.ReadLine();

                if (tank == "cube")
                {
                    Console.WriteLine("Please enter the side of the cube:");
                    int side = Convert.ToInt32(Console.ReadLine());
                    _solid = new Solid(new Rectangle(side, side), side);
                }
                else if (tank == "cuboid")
                {
                    Console.WriteLine("Please enter the length of the cuboid:");
                    int lenght = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the breath of the cuboid:");
                    int breadth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the height of the cuboid:");
                    int height = Convert.ToInt32(Console.ReadLine());
                    _solid = new Solid(new Rectangle(lenght, breadth), height);
                }
                else if (tank == "cylinder")
                {
                    Console.WriteLine("Please enter the radius of the cylinder:");
                    int radius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the height of the cylinder:");
                    int height = Convert.ToInt32(Console.ReadLine());
                    _solid = new Solid(new Circle(radius), height);
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                }

                Console.WriteLine($"The volume of the watertank is:{_volumeService.Volume(_solid)}");
            }
        }
    }
}
