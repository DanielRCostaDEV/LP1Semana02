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

        }
    }
}
