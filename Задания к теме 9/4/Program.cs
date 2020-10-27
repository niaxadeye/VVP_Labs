using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число C: ");
            int C = Convert.ToInt32(Console.ReadLine());

            int Ax = A / C;
            int Bx = B / C;

            int res = Ax * Bx;
            Console.WriteLine($"Rоличество квадратов, размещенных на прямоугольнике со сторонами {A} на {B} - {res}");

            int Sr = A * B - res;
            Console.WriteLine($"Площадь незанятой части прямоугольника - {Sr}");
        }
    }
}
