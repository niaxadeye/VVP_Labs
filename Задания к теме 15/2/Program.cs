using System;
using System.Security.Cryptography.X509Certificates;

namespace _2
{
    class Program
    {
        public static double Sign(double X)
        {
            if (X < 0)
            {
                return -1;
            }
            if (X == 0)
            {
                return 0;
            }
            if(X > 0)
            {
                return 1;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            Double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число B: ");
            Double B = Convert.ToDouble(Console.ReadLine());

            double res = Sign(A) + Sign(B);
            Console.WriteLine($"Sign(A) + Sign(B) = {res}");
        }
    }
}
