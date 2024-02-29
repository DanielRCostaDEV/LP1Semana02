using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Height and Radius
            Console.WriteLine("Please, insert the cylinder height: ");
            string h = Console.ReadLine();

            Console.WriteLine("Please insert the cylinder radius");
            string rad = Console.ReadLine();

            float height = float.Parse(h);
            float r = float.Parse(rad);

            //Volume of the Cylinder
            float v = MathF.PI*MathF.Pow(r,2)*height;
            Console.WriteLine($"The volume of the cylinder is {v}");

            //Surface Area
            float s = 2*MathF.PI*r*(r+height);
            Console.WriteLine($"The cylinder surface area is {s}")

        }
    }
}
