using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0, B = 0, C = 0, Ax, Bx, Cx;
            int k = 0;
            do
            {
                Console.Write("Введите число A: ");
                try
                {
                    A = Convert.ToDouble(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных");
                    Console.ResetColor();
                }
            } while (k == 0);
            k = 0;
            do
            {
                Console.Write("Введите число B: ");
                try
                {
                    B = Convert.ToDouble(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных");
                    Console.ResetColor();
                }
            } while (k == 0);
            do
            {
                Console.Write("Введите число C: ");
                try
                {
                    C = Convert.ToDouble(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных");
                    Console.ResetColor();
                }
            } while (k == 0);
            Ax = A;
            Bx = B;
            Cx = C;

            B = Ax;
            C = Bx;
            A = Cx;

            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
            Console.WriteLine($"C = {C}");

        }
    }
}
