using System;

namespace _6
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Дана система линейных уравнений вида:");
            Console.WriteLine("A1*x + B1*y = C1");
            Console.WriteLine("A2*x + B2*y = C2");

            Console.Write("Введите коэффицент A1: ");
            int A1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффицент B1: ");
            int B1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффицент C1: ");
            int C1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите коэффицент A2: ");
            int A2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффицент B2: ");
            int B2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффицент C2: ");
            int C2 = Convert.ToInt32(Console.ReadLine());

            double det = A1 * B2 - A2 * B1;
            double x = (C1 * B2 - C2 * B1) / det;
            double y = (A1 * C2 - A2 * C1) / det;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");


            return 0;
        }
    }
}
