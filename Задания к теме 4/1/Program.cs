using System;

namespace _1
{
    class Program
    {
        static public int calc_S(int a, int b)
        {
            int S;
            S = a * b;
            return S;
        }
        static public int calc_P(int a, int b)
        {
            int P;
            P = 2*(a + b);
            return P;
        }
        static void Main(string[] args)
        {
            int a, b, S, P;
            Console.Write("Ввведите ширину прямоугольника: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввведите длину прямоугольника: ");
            b = Convert.ToInt32(Console.ReadLine());
            S = calc_S(a, b);
            P = calc_P(a, b);
            Console.WriteLine($"Площадь прямоугольника со стронами {a} и {b} равна {S}, а периметр равен {P}");
        }
    }
}
