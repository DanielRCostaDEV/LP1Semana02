using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb = sbyte.MinValue;
            sbyte sb1 = sbyte.MaxValue;
            Console.WriteLine($"sbyte min: {sb} sbyte max: {sb1}");

            short sh = short.MinValue;
            short sh1 = short.MaxValue;
            Console.WriteLine($"short min: {sh} short max: {sh1}");
            
            int i = int.MinValue;
            int i1 = int.MaxValue;
            Console.WriteLine($"int min: {i} int max: {i1}");

            long log = long.MinValue;
            long log1 = long.MaxValue;
            Console.WriteLine($"long min: {log} long max: {log1}");

            byte by = byte.MinValue;
            byte by1 = byte.MaxValue;
            Console.WriteLine($"byte min: {by} byte max: {by1}");

            ushort us = ushort.MinValue;
            ushort us1 = ushort.MaxValue;
            Console.WriteLine($"ushort min: {us} ushort max: {us1}");

            uint ui = uint.MinValue;
            uint ui1 = uint.MaxValue;
            Console.WriteLine($"uint min: {ui} uint max: {ui1}");
            
            ulong ul = ulong.MinValue;
            ulong ul1 = ulong.MaxValue;
            Console.WriteLine($"ulong min: {ul} ulong max: {ul1}");

            char ch = char.MinValue;
            char ch1 = char.MaxValue;
            Console.WriteLine($"char min: {ch} char max: {ch1}");

            float fl = float.MinValue;
            float fl1 = float.MaxValue;
            Console.WriteLine($"float min: {fl} float max: {fl1}");

            double db = double.MinValue;
            double db1 = double.MaxValue;
            Console.WriteLine($"double min: {db} double max: {db1}");

            decimal de = decimal.MinValue;
            decimal de1 = decimal.MaxValue;
            Console.WriteLine($"decimal min: {de} decimal max: {de1}");

            //Infinite

            float infP = float.PositiveInfinity;
            Console.WriteLine($"Positive infinite: {infP}");
            float infM = float.NegativeInfinity;
            Console.WriteLine($"Negative infinite: {infM}");

            double infA = double.PositiveInfinity;
            Console.WriteLine($"Positive infinite: {infA}");
            double infS = double.NegativeInfinity;
            Console.WriteLine($"Negative infinite: {infS}");

            //NaN

            double nand = double.NaN;
            Console.WriteLine($"Double NaN: {nand}");
            float nanf = float.NaN;
            Console.WriteLine($"Float NaN: {nanf}");

            // uint overflow

            x = ushort.MinValue;
            Console.WriteLine((ushort)(x - 1));
            uint x = ushort.MaxValue;
            Console.WriteLine((ushort)(x + 1));

            // float overflow
            float y = 5 * float.MaxValue;
            Console.WriteLine(y);
            float z = float.MinValue + 5;
            Console.WriteLine(z);

            // float underflow
            float uv = 0.25e-38f;
            float result = uv / 2.0f;
            Console.WriteLine(result);

        }
    }
}
