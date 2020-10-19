using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину отрезка A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину отрезка B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int R = A / B;
            Console.WriteLine($"На отрезке А возможно разместить {R} отрезка/отрезков B");
        }
    }
}
