using System;

namespace _1
{
    class Program
    {
        public static void PowerA3(double A, out double B)
        {
            B = A * A * A;            
        }
        static void Main(string[] args)
        {
            double b;
            for(double i = 3; i < 8; i++)
            {
                PowerA3(i,out b);
                Console.WriteLine($"{i}^3 = {b}");
            }
        }
    }
}
