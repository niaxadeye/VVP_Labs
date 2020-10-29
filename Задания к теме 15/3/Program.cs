using System;
using System.Reflection.Metadata.Ecma335;

namespace _3
{
    class Program
    {
        public static double RingS(double R1, double R2)
        {
            double R3 = Math.Abs(R1 - R2)/2;
            return 3.14 * R3 * R3;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите R1: ");
            double R1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите R2: ");
            double R2 = Convert.ToDouble(Console.ReadLine());
            double S3 = RingS(R1, R2);
            double S1 = 3.14 * R1 * R1;
            double S2 = 3.14 * R2 * R2;
            Console.WriteLine($"S1 = {S1}");
            Console.WriteLine($"S2 = {S2}");
            Console.WriteLine($"S3 = {S3}");
        }
    }
}
