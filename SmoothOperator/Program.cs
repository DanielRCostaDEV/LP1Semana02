using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks for a input from user
            Console.Write("Insert a non negative integer: ");
            string input = Console.ReadLine();

            // Conversion
            byte n = byte.Parse(input);

            //increase and decrease
            Console.WriteLine(--n);
            Console.WriteLine(++n);

        }
    }
}
