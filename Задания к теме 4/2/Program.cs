using System;

namespace _2
{
    class Program
    {
        static public double calc_L(int d)
        {
            double pi = 3.14, L;
            L = pi * d;
            return L;

        }
        static void Main(string[] args)
        {
            int d;
            double L;
            Console.Write("Введите диаметр окружности: ");
            d = Convert.ToInt32(Console.ReadLine());
            L = calc_L(d);
            Console.WriteLine($"Для окружности с диаметром {d}, ддлина будет равна {L}");
        }
    }
}
